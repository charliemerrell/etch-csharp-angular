import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AnswerFlashcardsComponent } from './answer-flashcards.component';

describe('AnswerFlashcardsComponent', () => {
  let component: AnswerFlashcardsComponent;
  let fixture: ComponentFixture<AnswerFlashcardsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AnswerFlashcardsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AnswerFlashcardsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
