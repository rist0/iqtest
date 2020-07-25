import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { AdminLoginComponent } from './admin-login/admin-login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AdminManageQuestionsComponent } from './admin-manage-questions/admin-manage-questions.component';
import { AdminAddNewQuestionComponent } from './admin-add-new-question/admin-add-new-question.component';
import { AdminViewQuestionComponent } from './admin-view-question/admin-view-question.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';


@NgModule({
  declarations: [AdminLoginComponent, AdminManageQuestionsComponent, AdminAddNewQuestionComponent, AdminViewQuestionComponent],
  imports: [
    CommonModule,
    AdminRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    FontAwesomeModule
  ]
})
export class AdminModule { }
