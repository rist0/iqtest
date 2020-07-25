import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomepageComponent } from './app/homepage/homepage.component';
import { NavbarComponent } from './app/navbar/navbar.component';
import { FooterComponent } from './app/footer/footer.component';
import { MainContentComponent } from './app/main-content/main-content.component';
import { ContactComponent } from './app/contact/contact.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { PrivacyPolicyComponent } from './app/privacy-policy/privacy-policy.component';
import { TermsOfServiceComponent } from './app/terms-of-service/terms-of-service.component';
import { ReactiveFormsModule } from '@angular/forms';
import { JwtInterceptor } from './_helpers/jwt.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    HomepageComponent,
    NavbarComponent,
    FooterComponent,
    MainContentComponent,
    ContactComponent,
    PrivacyPolicyComponent,
    TermsOfServiceComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    RouterModule,
    FontAwesomeModule,
    ReactiveFormsModule
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
