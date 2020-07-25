import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { IqtestComponent } from './iqtest/iqtest.component';
import { HomepageComponent } from '../app/homepage/homepage.component';


const routes: Routes = [
  { path: '', component: HomepageComponent,
    children: [
      { path: '', component: IqtestComponent }
    ] 
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class IqtestRoutingModule { }
