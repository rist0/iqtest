import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminManageQuestionsComponent } from './admin-manage-questions.component';

describe('AdminManageQuestionsComponent', () => {
  let component: AdminManageQuestionsComponent;
  let fixture: ComponentFixture<AdminManageQuestionsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminManageQuestionsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminManageQuestionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
