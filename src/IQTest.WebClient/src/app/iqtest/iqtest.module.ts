import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { IqtestRoutingModule } from './iqtest-routing.module';
import { IqtestComponent } from './iqtest/iqtest.component';
import { QuestionService } from '../_services/question.service';
import { HttpClientModule } from '@angular/common/http';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { SubmitresultformComponent } from './submitresultform/submitresultform.component';


@NgModule({
  declarations: [IqtestComponent, SubmitresultformComponent],
  imports: [
    CommonModule,
    IqtestRoutingModule,
    HttpClientModule,
    FormsModule,
    FontAwesomeModule,
    ReactiveFormsModule
  ],
  providers: [
    QuestionService
  ]
})
export class IqtestModule { }
