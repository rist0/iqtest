import { Component, OnInit } from '@angular/core';
import { QuestionService } from 'src/app/_services/question.service';
import { ActivatedRoute, Router } from '@angular/router';
import { IQuestion } from 'src/app/_models';

import { faChevronLeft } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-admin-view-question',
  templateUrl: './admin-view-question.component.html',
  styleUrls: ['./admin-view-question.component.css']
})
export class AdminViewQuestionComponent implements OnInit {
  pageTitle: string;
  question: IQuestion;
  errorMessage: string;

  faChevronLeft = faChevronLeft;

  constructor(private questionService: QuestionService,
              private route: ActivatedRoute,
              private router: Router) { }

  ngOnInit(): void {
    const param = this.route.snapshot.paramMap.get('id');
    if(param) {
      const id = +param;
      this.getQuestion(id);
    }
  }

  getQuestion(id: number): void {
    this.questionService.getQuestion(id).subscribe({
      next: question => {
        this.question = question;
        this.pageTitle = `Question ${question.id} Details`;
      },
      error: err => this.errorMessage = err
    });
  }

  onBack(): void {
    this.router.navigate(['admin']);
  }

}
