import { Component, OnInit } from '@angular/core';
import { IOption } from 'src/app/_models';
import { FormGroup, FormBuilder, Validators, FormArray } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { QuestionService } from 'src/app/_services/question.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-add-new-question',
  templateUrl: './admin-add-new-question.component.html',
  styleUrls: ['./admin-add-new-question.component.css']
})
export class AdminAddNewQuestionComponent implements OnInit {
  //questionDifficulty: number = 1;
  questionOptions: IOption[] = [];

  form: FormGroup;
  submitted: boolean = false;
  loading: boolean = false;

  numberOfOptions: number;

  qImage: File = null;
  
  constructor(private formBuilder: FormBuilder,
              private http: HttpClient,
              private questionService: QuestionService,
              private router: Router) { }

  ngOnInit(): void {
    this.form = this.formBuilder.group({
      questionTitle: ['', [Validators.required, Validators.minLength(10)]],
      questionDifficulty: ['1', [Validators.required, Validators.min(1), Validators.max(10)]],
      questionImage: [null, [Validators.required]],
      numberOfOptions: ['', Validators.required],
      options: new FormArray([])
    });
  }

  get f() { return this.form.controls; };
  get opts() { return this.f.options as FormArray; }

  onChangeOptions(e) {
    this.numberOfOptions = e.target.value || 0;
    if (this.opts.length < this.numberOfOptions) {
      for (let i =  this.opts.length; i < this.numberOfOptions; i++) {
        this.opts.push(this.formBuilder.group({
          image: ['', Validators.required],
          isAnswer: ['']
        }));
      }
    }
    else {
      for (let i = this.opts.length; i >= this.numberOfOptions; i--) {
        this.opts.removeAt(i);
      }
    }
  }

  onChangeQuestionImage(event){
    if (event.target.files.length > 0) {
      this.qImage = event.target.files[0];
    }
    else
    {
      this.qImage = null;
    }
  }

  onChangeOptionImages(event, index) {
    if (event.target.files && event.target.files.length === 0){
      this.form.get(`options.${index}.image`).patchValue('');
      return;
    }

    // TODO: Implement size check from env

    const fileReader: FileReader = new FileReader();

    fileReader.readAsDataURL(event.target.files[0]);

    fileReader.onload = () => {
      //console.log(e.target.result);
      this.form.get(`options.${index}.image`).patchValue(fileReader.result);
    }

    //this.form.get(`options.${index}.image`).patchValue(event.target.files[0]);
  }

  onSubmit() {
    this.submitted = true;

    if(this.form.invalid) {
      return;
    }

    const formData = new FormData();
    formData.append('name', this.form.value.questionTitle);
    formData.append('difficulty', this.form.value.questionDifficulty);
    formData.append('questionImage', this.qImage);
    formData.append('options', JSON.stringify(this.form.value.options));

    this.loading = true;
    this.questionService.postQuestion(formData).subscribe({
      next: data => {
        console.log("Successfully added question.");
        this.router.navigate(['/admin']);
      },
      error: error => {
        this.loading = false;
        console.log(error);
      }
    });

    //this.http.post(`${environment.apiUrl}` + '/api/questions/new', formData).subscribe(res => { console.log(res) });
  }

  onReset() {
    this.submitted = false;
    console.log(this.form.value);
    this.form.reset();
    this.opts.clear();
  }

  onClear() {
    console.log(this.opts.value);
    this.submitted = false;
    // for(let i = 0; i < this.form.value.numberOfOptions; i++) {
    //   this.form.get(`options.${i}.image`).patchValue('');
    // }
    this.opts.reset();
  }

}
