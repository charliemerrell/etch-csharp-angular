import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Flashcard } from './models/flashcard';
import { Convert } from './models/convert';
import { map } from 'rxjs/operators';
import { Answer } from './models/answer';

@Injectable({
  providedIn: 'root'
})
export class FlashcardService {

  baseUrl = "/api/flashcards";

  constructor(private httpClient: HttpClient) { }

  getAllFlashcards() {
    return this.httpClient.get(this.baseUrl, { observe: 'body', responseType: 'text' }).pipe(map(Convert.toFlashcardArray));
  }

  createFlashcard(flashcard: Flashcard) {
    return this.httpClient.post(this.baseUrl, flashcard);
  }

  markFlashcard(flashcardId: number, correct: boolean) {
    let answer: Answer = {
      isCorrect: correct,
      createdAt: new Date(),
      flashcardId
    }
    return this.httpClient.post(`${this.baseUrl}/${flashcardId}/answers`, answer);
  }
}
