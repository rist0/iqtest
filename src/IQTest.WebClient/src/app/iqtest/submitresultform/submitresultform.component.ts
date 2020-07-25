import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { EmailService } from 'src/app/_services/email.service';
import { IEmail } from 'src/app/_models';

@Component({
  selector: 'app-submitresultform',
  templateUrl: './submitresultform.component.html',
  styleUrls: ['./submitresultform.component.css']
})
export class SubmitresultformComponent implements OnInit {
  submitResultForm: FormGroup;
  submitted: boolean = false;
  submitMessageResponse: string = '';
  loading: boolean = false;
  hasSentMail: boolean = false;

  @Input() iqTestScore: number;

  constructor(private formBuilder: FormBuilder,
              private emailService: EmailService) { }

  ngOnInit(): void {
    this.submitResultForm = this.formBuilder.group({
      fullName: ['', Validators.required],
      emailAddress: ['', [Validators.required, Validators.email]]
    });
  }

  get f() { return this.submitResultForm.controls; }

  onSubmit() {
    this.submitted = true;

    if (this.submitResultForm.invalid) {
      return;
    }

    let userEmailAddress: string = this.submitResultForm.value.emailAddress;
    let userFullName: string = this.submitResultForm.value.fullName;
    
    let email: IEmail = {
      email: userEmailAddress,
      subject: `Your IQ Test Results`,
      message: `Hello ${userFullName}.<br>
      Your IQ Test result is: ${this.iqTestScore}.<br>
      Thank you for using our IQ Test!`
    };

    this.loading = true;
    this.submitMessageResponse = 'Attempting to send e-mail... please wait a few seconds.'
    this.emailService.sendEmail(email).subscribe({
      next: data => {
        this.submitMessageResponse = 'Successfully sent results.';
        this.loading = false;
        this.hasSentMail = true;
      },
      error: err => {
        this.submitMessageResponse = `Failed to send results. Error: ${err}`;
        this.loading = false;
      }
    });
  }

  // onReset() {
  //   this.submitted = false;
  //   this.submitResultForm.reset();
  // }
}
