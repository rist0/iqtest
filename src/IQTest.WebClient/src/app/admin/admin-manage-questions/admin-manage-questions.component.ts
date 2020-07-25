import { Component, OnInit } from '@angular/core';
import { QuestionService } from 'src/app/_services/question.service';
import { IQuestion } from 'src/app/_models';

import { faEye, faTrashAlt, faPlus, faTimesCircle } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-admin-manage-questions',
  templateUrl: './admin-manage-questions.component.html',
  styleUrls: ['./admin-manage-questions.component.css']
})
export class AdminManageQuestionsComponent implements OnInit {
  faEye = faEye;
  faTrashAlt = faTrashAlt;
  faPlus = faPlus;
  faTimesCircle = faTimesCircle;

  questions: IQuestion[] = [];
  error: string = '';
  selectedQuestion: IQuestion = {};

  constructor(private questionService: QuestionService) { }

  ngOnInit(): void {
    this.questionService.getQuestions().subscribe({
      next: data => this.questions = data,
      error: err => this.error = err
    });
  }

  onDeleteClicked(question: IQuestion) {
    this.selectedQuestion = question;
  }

  onDeleteQuestion(questionId: number) {
    this.questionService.deleteQuestion(questionId).subscribe({
      next: data => { 
        //console.log(data);
        this.questions = this.questions.filter(q => q.id !== questionId);
      },
      error: err => this.error = err
    });
  }

}