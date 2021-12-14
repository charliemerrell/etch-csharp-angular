import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AnswerFlashcardsComponent } from './answer-flashcards/answer-flashcards.component';
import { ViewAllFlashcardsComponent } from './view-all-flashcards/view-all-flashcards.component';
import { CreateFlashcardComponent } from './create-flashcard/create-flashcard.component';
import { FormControl, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    AnswerFlashcardsComponent,
    ViewAllFlashcardsComponent,
    CreateFlashcardComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
