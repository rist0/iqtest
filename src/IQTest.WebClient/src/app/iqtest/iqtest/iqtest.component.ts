import { Component, OnInit } from '@angular/core';

import { ITestConfig, IPager, IQuestion, TestMode, IOption, IEmail } from '../../_models/index';
import { QuestionService} from '../../_services/question.service';
import { EmailService } from '../../_services/email.service';

import { faStepBackward, faFastBackward, faFastForward, faStepForward, faPlay } from '@fortawesome/free-solid-svg-icons';


@Component({
  selector: 'app-iqtest',
  templateUrl: './iqtest.component.html',
  styleUrls: ['./iqtest.component.css']
})
export class IqtestComponent implements OnInit {
  faStepBackward = faStepBackward;
  faFastBackward = faFastBackward;
  faFastForward = faFastForward;
  faStepForward = faStepForward;
  faPlay = faPlay;

  testConfig: ITestConfig = {
    numberOfQuestions: 10, // finished
    allowBack: true, // finished
    allowReview: true, // finished
    autoMove: false, // finished
    duration: 0, // finished
    requiredAll: true, // finished
    shuffleQuestions: true, // finished
    shuffleOptions: false, // TODO
    showClock: true,  // finished
    showPager: true // finished
  }

  testName: string = 'IQ Test';
  testDescription: string = 'Test your IQ with our free test.';
  testQuestions: IQuestion[] = [];
  testMode: TestMode = TestMode.None;
  testModeType: typeof TestMode = TestMode;

  testPager: IPager = {
    index: 0,
    size: 1,
    count: 1
  }

  timer: any = null;

  startTime: Date;
  endTime: Date;
  elapsedTime: string = '00:00';
  duration: string = '';

  questions: IQuestion[] = [];
  loadingQuestions: boolean = false;

  testFinalScore: number;

  constructor(private questionService: QuestionService,
              private emailService: EmailService) { }

  ngOnInit(): void {
    this.getQuestions();
  }

  switchReviewMode() : void {
    if (this.testMode === TestMode.Test)
    {
      this.testMode = TestMode.Review;
    }
    else {
      this.testMode = TestMode.Test;
    }
  }

  // submit the test results
  submitTest() {
    console.log('submit quiz');

    if (this.testConfig.requiredAll && !this.areAllQuestionsAnswered()) {
      console.log('all the questions are NOT answered!');
      return;
    }

    console.log('after required all check');

    let totalCorrectAnswers = this.calculateAmountOfCorrectAnswers();
    
    this.testFinalScore = Math.floor(this.calculateIqTestScore(totalCorrectAnswers));

    this.testMode = TestMode.Result;

    this.timer = clearInterval(); // cleanup stop the timer
  }

  // Calculate the IQ Test score/result
  calculateIqTestScore(correctAnswers: number) : number {
    return correctAnswers * (130/this.testConfig.numberOfQuestions) + 20;
  }

  // Return the amount of correctly answered questions
  calculateAmountOfCorrectAnswers() : number {
    let correctAnswers = 0;

    for (let i = 0; i < this.testQuestions.length; i++)
    {
      if (this.isCorrect(this.testQuestions[i])) {
        correctAnswers++;
      }
    }

    return correctAnswers;
  }

  // setup the questions for the test
  setupTestQuestions() : IQuestion[] {
    let questions: IQuestion[] = [];
    
    // shuffle the questions
    if (this.testConfig.shuffleQuestions) {
      questions =  this.shuffle(this.questions);
    }

    // take the first numberOfOptions questions
    questions = this.questions.slice(0, this.testConfig.numberOfQuestions);

    // sort them by difficulty
    questions.sort((a, b) => {
      const aDiff = a.difficulty;
      const bDiff = b.difficulty;

      if (aDiff > bDiff) return 1;
      if (bDiff > aDiff) return -1;

      return 0;
    });

    // return
    return questions;
  }

  // get all the questions from the database
  getQuestions() : void {
    this.loadingQuestions = true;
    this.questionService.getQuestionsWithOptions().subscribe({
      next: questions => {
        this.questions = questions;
        this.testQuestions = this.setupTestQuestions();
        this.loadingQuestions = false;
      },
      error: err => {
        //console.log(err);
        this.loadingQuestions = false;
      }
    });
  }

  // start the test
  startTest(): void {
    if(this.questions.length <= 0) {
      console.log('No questions in the database to start the quiz with.');
      return;
    }

    this.testPager.count = this.testQuestions.length;
    this.startTime = new Date();
    this.elapsedTime = '00:00';
    this.timer = setInterval(() => { this.tick(); }, 1000);
    this.duration = this.parseTime(this.testConfig.duration);
    this.testMode = TestMode.Test;

    console.log(this.testPager);
  }

  tick() : void {
    const now = new Date();
    const diff = (now.getTime() - this.startTime.getTime()) / 1000;
    if (diff >= this.testConfig.duration){
      // time out - submit the quiz
    }
    this.elapsedTime = this.parseTime(diff);
  }

  parseTime(totalSeconds: number) : string {
    let mins: string | number = Math.floor(totalSeconds / 60);
    let secs: string | number = Math.round(totalSeconds % 60);
    mins = (mins < 10 ? '0' : '') + mins;
    secs = (secs < 10 ? '0' : '') + secs;
    return `${mins}:${secs}`;
  }

  onSelect(question: IQuestion, option: IOption) {
    question.options.forEach((x) => { 
      if (x.id !== option.id) x.isSelected = false;
    });
    
    if (this.testConfig.autoMove) {
      this.goTo(this.testPager.index + 1);
    }
  }

  goTo(index: number) {
    if (index >= 0 && index < this.testPager.count) {
      this.testPager.index = index;
      this.testMode = TestMode.Test;
    }
  }

  isAnswered(question: IQuestion) : boolean {
    return question.options.find(x => x.isSelected) ? true : false;
  };

  isCorrect(question: IQuestion) : boolean {
    return question.options.every(x => x.isSelected === x.isAnswer) ? true : false;
  };

  areAllQuestionsAnswered() : boolean {
    for (let i = 0; i < this.testQuestions.length; i++)
    {
      if (!this.isAnswered(this.testQuestions[i])) return false;
    }
    return true;
  }

  getQuestion() : IQuestion[] {
    let question: IQuestion[] = 
      (this.testQuestions) ?
      this.testQuestions.slice(this.testPager.index, this.testPager.index + this.testPager.size) : [];

    return question;
    // return (this.testQuestions) ?
    //   this.testQuestions.slice(this.testPager.index, this.testPager.index + this.testPager.size) : [];
  }

  shuffle(array: any[]) : any[] {
    var currentIndex: number = array.length;
    var temporaryValue: any; 
    var randomIndex: number;
  
    // While there remain elements to shuffle
    while (0 !== currentIndex) {
  
      // Pick a remaining element
      randomIndex = Math.floor(Math.random() * currentIndex);
      currentIndex -= 1;
  
      // And swap it with the current element
      temporaryValue = array[currentIndex];
      array[currentIndex] = array[randomIndex];
      array[randomIndex] = temporaryValue;
    }
  
    return array;
  }
}