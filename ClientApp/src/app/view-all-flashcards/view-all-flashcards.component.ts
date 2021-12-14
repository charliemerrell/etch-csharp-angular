import { Component, OnInit } from '@angular/core';
import { FlashcardService } from '../flashcard.service';
import { Flashcard } from '../models/flashcard';

@Component({
  selector: 'app-view-all-flashcards',
  templateUrl: './view-all-flashcards.component.html',
  styleUrls: ['./view-all-flashcards.component.sass']
})
export class ViewAllFlashcardsComponent implements OnInit {

  flashcards!: Flashcard[];

  constructor(private flashcardService: FlashcardService) { }

  ngOnInit(): void {
    this.flashcardService.getAllFlashcards().subscribe((flashcardArr) => {
      this.flashcards = flashcardArr;
    });
  }

}
