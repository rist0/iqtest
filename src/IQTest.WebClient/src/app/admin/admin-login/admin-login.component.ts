import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserService } from 'src/app/_services/user.service';
import { first } from 'rxjs/operators';

@Component({
  selector: 'app-admin-login',
  templateUrl: './admin-login.component.html',
  styleUrls: ['./admin-login.component.css']
})
export class AdminLoginComponent implements OnInit {
  form: FormGroup;
  loading: boolean = false;
  submitted: boolean = false;
  failedSignIn: boolean = false;
  err: any;

  constructor(private formBuilder: FormBuilder,
              private router: Router,
              private userService: UserService) 
  {
    // check if logged if, then redirect to dashboard?
  }

  ngOnInit(): void {
    this.form = this.formBuilder.group({
      username: ['', [Validators.required, Validators.minLength(3)]],
      password: ['', [Validators.required, Validators.minLength(6)]]
    });
  }

  get f() {
    return this.form.controls;
  }

  onSubmit() {
    this.submitted = true;
    this.failedSignIn = false;

    if (this.form.invalid) { 
      return;
    }

    this.loading = true;
    this.userService.login(this.f.username.value, this.f.password.value)
        .pipe(first())
        .subscribe(
          data => {
            this.router.navigate(['']);
          },
          error => {
            this.err = error;
            this.failedSignIn = true;
            this.loading = false;
          }
        );
  }

}
