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

  constructor(private flashcardService: FlashcardService) { }

  ngOnInit(): void {
    this.flashcardService.getAllFlashcards().subscribe((flashcardArr) => {
      this.flashcards = flashcardArr;
    });
  }

}
