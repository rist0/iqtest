import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SubmitresultformComponent } from './submitresultform.component';

describe('SubmitresultformComponent', () => {
  let component: SubmitresultformComponent;
  let fixture: ComponentFixture<SubmitresultformComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SubmitresultformComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SubmitresultformComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
