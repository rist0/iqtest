import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomepageComponent } from './app/homepage/homepage.component';
import { MainContentComponent } from './app/main-content/main-content.component';
import { ContactComponent } from './app/contact/contact.component';
import { PrivacyPolicyComponent } from './app/privacy-policy/privacy-policy.component';
import { TermsOfServiceComponent } from './app/terms-of-service/terms-of-service.component';

import { AuthGuard } from './_helpers/auth.guard';

const routes: Routes = [
  { path: '', component: HomepageComponent,
    children: [
      { path: '', component: MainContentComponent },
      { path: 'contact', component: ContactComponent },
      { path: 'privacy-policy', component: PrivacyPolicyComponent },
      { path: 'terms-of-service', component: TermsOfServiceComponent }
    ] 
  },
  { path: 'iqtest', loadChildren: () => import('./iqtest/iqtest.module').then(m => m.IqtestModule) },
  { path: 'admin', loadChildren: () => import('./admin/admin.module').then(m => m.AdminModule) },
  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {scrollPositionRestoration: 'enabled'})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
