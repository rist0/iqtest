import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { UserService } from '../_services/user.service';
import { environment } from '../../environments/environment';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {

  constructor(private userService: UserService) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    const user = this.userService.userValue;
    const isLoggedIn = user && user.token;
    const isApiUrl = request.url.startsWith(environment.apiUrl);

    if (isLoggedIn && isApiUrl) {
        request = request.clone({
            setHeaders: {
                Authorization: `Bearer ${user.token}`
            }
        });
    }

    return next.handle(request);
  }
}
