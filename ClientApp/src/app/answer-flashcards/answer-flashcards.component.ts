import { Component, OnInit } from '@angular/core';
import { FlashcardService } from '../flashcard.service';

@Component({
  selector: 'app-answer-flashcards',
  templateUrl: './answer-flashcards.component.html',
  styleUrls: ['./answer-flashcards.component.sass']
})
export class AnswerFlashcardsComponent implements OnInit {

  constructor(private flashcardService: FlashcardService) { }

  ngOnInit(): void {
    this.flashcardService.getAllFlashcards().subscribe(console.log);
  }

}
