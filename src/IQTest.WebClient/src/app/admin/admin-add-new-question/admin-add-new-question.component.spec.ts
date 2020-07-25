import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminAddNewQuestionComponent } from './admin-add-new-question.component';

describe('AdminAddNewQuestionComponent', () => {
  let component: AdminAddNewQuestionComponent;
  let fixture: ComponentFixture<AdminAddNewQuestionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminAddNewQuestionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminAddNewQuestionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
