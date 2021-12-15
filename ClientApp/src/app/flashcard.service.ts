import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Flashcard } from './models/flashcard';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FlashcardService {

  baseUrl = "/api/flashcards";

  constructor(private httpClient: HttpClient) { }

  getAllFlashcards() {
    return this.httpClient.get(this.baseUrl) as Observable<Flashcard[]>;
  }

  getRipeFlashcards() {
    const params = new HttpParams().set('ripe', true);
    return this.httpClient.get(this.baseUrl, { params }) as Observable<Flashcard[]>
  }

  createFlashcard(flashcard: Flashcard) {
    return this.httpClient.post(this.baseUrl, flashcard);
  }

  markFlashcard(flashcardId: number, isCorrect: boolean) {
    return this.httpClient.post(`${this.baseUrl}/${flashcardId}/answers`, { isCorrect });
  }
}
