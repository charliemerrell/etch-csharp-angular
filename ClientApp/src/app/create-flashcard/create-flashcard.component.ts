import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { FlashcardService } from '../flashcard.service';
import { Flashcard } from '../models/flashcard';

@Component({
  selector: 'app-create-flashcard',
  templateUrl: './create-flashcard.component.html',
  styleUrls: ['./create-flashcard.component.sass']
})
export class CreateFlashcardComponent implements OnInit {

  prompt = new FormControl('', Validators.required);
  correctAnswer = new FormControl('', Validators.required);

  constructor(private flashcardService: FlashcardService) { }

  ngOnInit(): void {
  }

  submit(): void {
    let flashcard: Flashcard = {
      prompt: this.prompt.value,
      correctAnswer: this.correctAnswer.value,
      createdAt: new Date(),
      answers: []
    }
    this.flashcardService.createFlashcard(flashcard).subscribe(() => {
      this.prompt.setValue('');
      this.correctAnswer.setValue('');
    });
  }

}
