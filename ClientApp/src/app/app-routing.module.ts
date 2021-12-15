import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AnswerFlashcardsComponent } from './answer-flashcards/answer-flashcards.component';
import { CreateFlashcardComponent } from './create-flashcard/create-flashcard.component';

const routes: Routes = [
  { path: "create-flashcard", component: CreateFlashcardComponent },
  { path: "answer-flashcards", component: AnswerFlashcardsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
