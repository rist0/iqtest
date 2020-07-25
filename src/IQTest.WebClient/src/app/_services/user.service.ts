import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { map } from 'rxjs/operators';

import { IUser } from '../_models/index';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private userSubject: BehaviorSubject<IUser>;
  public user: Observable<IUser>;

  constructor(private router: Router,
              private http: HttpClient) {
    this.userSubject = new BehaviorSubject<IUser>(JSON.parse(localStorage.getItem('user')));
    this.user = this.userSubject.asObservable();
  }

  public get userValue(): IUser {
    return this.userSubject.value;
  }

  login (username, password)
  {
      return this.http.post<IUser>(`${environment.apiUrl}/api/users/authenticate`, { username, password })
          .pipe(map(user => {
              localStorage.setItem('user', JSON.stringify(user));
              this.userSubject.next(user);
              return user;
          }));
  }

  logout() {
      localStorage.removeItem('user');
      this.userSubject.next(null);
      this.router.navigate(['/login']);
  }
}
