import { Component, OnInit } from '@angular/core';
import { FlashcardService } from '../flashcard.service';
import { Flashcard } from '../models/flashcard';

@Component({
  selector: 'app-answer-flashcards',
  templateUrl: './answer-flashcards.component.html',
  styleUrls: ['./answer-flashcards.component.sass']
})
export class AnswerFlashcardsComponent implements OnInit {

  flashcards!: Flashcard[];
  showingAnswer: boolean = false;

  constructor(private flashcardService: FlashcardService) { }

  ngOnInit(): void {
    this.flashcardService.getRipeFlashcards().subscribe((flashcardArr) => {
      this.flashcards = flashcardArr;
    });
  }

  showAnswer() {
    this.showingAnswer = true;
  }

  markAnswer(correct: boolean) {
    this.flashcardService.markFlashcard(this.flashcards[0].id as number, correct).subscribe(() => this.nextFlashcard())
  }

  nextFlashcard() {
    this.showingAnswer = false;
    this.flashcards.splice(0, 1);
  }

}
