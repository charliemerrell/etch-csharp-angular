import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FlashcardService {

  constructor(private httpClient: HttpClient) { }

  getAllFlashcards() {
    return this.httpClient.get("/api/flashcards");
  }
}
