import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { throwError } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';

import { environment } from '../../environments/environment';
import { IEmail } from '../_models';

@Injectable({
  providedIn: 'root'
})
export class EmailService {
  private baseUrl: string;

  constructor(private http: HttpClient) { 
    this.baseUrl = environment.apiUrl;
  }

  sendEmail(email: IEmail) {
    return this.http.post(this.baseUrl + `/api/email`, email).pipe(
      //tap(data => console.log('sendEmail(): ' + JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

  private handleError(err: HttpErrorResponse)
  {
      let errorMessage = '';
      if  (err.error instanceof ErrorEvent)
      {
          errorMessage = `An error occurred: ${err.error.message}`;
      }
      else
      {
          errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
      }

      console.error(errorMessage);
      return throwError(errorMessage);
  }

}
