import { Injectable } from '@angular/core';

import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';

import { IQuestion } from '../_models/index'
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {
  private baseUrl: string;

  constructor(private http: HttpClient) { 
    this.baseUrl = environment.apiUrl;
    //this.baseUrl = './assets/questions.json';
  }

  getQuestions() : Observable<IQuestion[]> {
    return this.http.get<IQuestion[]>(this.baseUrl + '/api/questions').pipe(
        //tap(data => console.log('getQuestions(): ' + JSON.stringify(data))),
        map(data =>
          data.map(q => ({...q, imagePath: `${environment.resourcesUrl}` + q.imagePath.replace(/[\\]/g, '/') }))
        ),
        //tap(data => console.log('getQuestions(): ' + JSON.stringify(data))),
        catchError(this.handleError)
    );
  }

  getQuestionsWithOptions() : Observable<IQuestion[]> {
    return this.http.get<IQuestion[]>(this.baseUrl + `/api/questions/full`).pipe(
      //tap(data => console.log(data)),
      map(data =>
        data.map(q => ({...q, imagePath: `${environment.resourcesUrl}` + q.imagePath.replace(/[\\]/g, '/'),
                        options: q.options.map(o => ({...o, imagePath: `${environment.resourcesUrl}` + o.imagePath.replace(/[\\]/g, '/') })) }))
      ),
      catchError(this.handleError)
    );
  }

  getQuestion(questionId: number) : Observable<IQuestion> {
    return this.http.get<IQuestion>(this.baseUrl + `/api/questions/${questionId}`).pipe(
      //tap(data => console.log('Data received: ' + JSON.stringify(data))),
      map(q => ({...q, imagePath: `${environment.resourcesUrl}` + q.imagePath.replace(/[\\]/g, '/'), 
                options: q.options.map(o => ({...o, imagePath: `${environment.resourcesUrl}` + o.imagePath.replace(/[\\]/g, '/') }) ) })
      ),
      //tap(data => console.log('getQuestion(id): ' + JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

  postQuestion(formData: FormData) {
    return this.http.post(this.baseUrl + `/api/questions/new`, formData).pipe(
      tap(data => console.log('postQuestion(): ' + JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

  deleteQuestion (questionId: number) {
    return this.http.delete(this.baseUrl + `/api/questions/${questionId}`).pipe(
      //tap(data => console.log('deleteQuestion(): ' + data)),
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
