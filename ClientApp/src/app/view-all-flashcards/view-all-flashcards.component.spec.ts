import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewAllFlashcardsComponent } from './view-all-flashcards.component';

describe('ViewAllFlashcardsComponent', () => {
  let component: ViewAllFlashcardsComponent;
  let fixture: ComponentFixture<ViewAllFlashcardsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewAllFlashcardsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewAllFlashcardsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
