import { Component, OnInit } from '@angular/core';

import { faEnvelope, faEraser } from '@fortawesome/free-solid-svg-icons';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

import { ContactMessageService } from '../../_services/contactmessage.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  faEnvelope = faEnvelope;
  faEraser = faEraser;

  contactForm: FormGroup;
  submitted: boolean = false;
  loading: boolean = false;

  submitMessageResponse: string = '';

  constructor(private formBuilder: FormBuilder,
              private contactMessageService: ContactMessageService) { }

  ngOnInit(): void {
    this.contactForm = this.formBuilder.group({
      fullName: ['', Validators.required],
      emailAddress: ['', [Validators.required, Validators.email]],
      subject: ['', [Validators.required, Validators.minLength(5)]],
      message: ['', [Validators.required, Validators.minLength(20), Validators.maxLength(200)]]
    });
  }

  get f() { return this.contactForm.controls; }

  onSubmit() {
    this.submitted = true;

    if (this.contactForm.invalid) {
      return;
    }

    //console.log(JSON.stringify(this.contactForm.value));

    this.loading = true;
    this.contactMessageService.sendContactMessage({...this.contactForm.value, dateReceived: new Date() }).subscribe({
      next: data => {
        this.loading = false;
        this.submitMessageResponse = 'Successfully sent message.';
      },
      error: err => { 
        this.submitMessageResponse = `Failed to send message. Error: ${err}`;
        this.loading = false;
      }
    });
  }

  onReset() {
    this.submitted = false;
    this.contactForm.reset();
  }
}
