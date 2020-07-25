import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomepageComponent } from '../app/homepage/homepage.component';
import { AdminLoginComponent } from './admin-login/admin-login.component';
import { AdminManageQuestionsComponent } from './admin-manage-questions/admin-manage-questions.component';
import { AdminAddNewQuestionComponent } from './admin-add-new-question/admin-add-new-question.component';
import { AdminViewQuestionComponent } from './admin-view-question/admin-view-question.component';
import { AuthGuard } from '../_helpers/auth.guard';

const routes: Routes = [
  { path: '', component: HomepageComponent,
    children: [
      { path: '', component: AdminManageQuestionsComponent, canActivate: [AuthGuard] },
      { path: 'login', component: AdminLoginComponent },
      { path: 'add-new-question', component: AdminAddNewQuestionComponent, canActivate: [AuthGuard] },
      { path: 'view-question/:id', component: AdminViewQuestionComponent, canActivate: [AuthGuard] }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
