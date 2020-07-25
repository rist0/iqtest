import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminViewQuestionComponent } from './admin-view-question.component';

describe('AdminViewQuestionComponent', () => {
  let component: AdminViewQuestionComponent;
  let fixture: ComponentFixture<AdminViewQuestionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminViewQuestionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminViewQuestionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
