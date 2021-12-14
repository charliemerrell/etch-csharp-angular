import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
@Component({
  selector: 'app-answer-flashcards',
  templateUrl: './answer-flashcards.component.html',
  styleUrls: ['./answer-flashcards.component.sass']
})
export class AnswerFlashcardsComponent implements OnInit {

  constructor(private httpClient: HttpClient) { }

  ngOnInit(): void {
    this.httpClient.get("/api/flashcards").subscribe(console.log);
  }

}
