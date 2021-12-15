import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AnswerFlashcardsComponent } from './answer-flashcards/answer-flashcards.component';
import { CreateFlashcardComponent } from './create-flashcard/create-flashcard.component';
import { ViewAllFlashcardsComponent } from './view-all-flashcards/view-all-flashcards.component';

const routes: Routes = [
  { path: "create-flashcard", component: CreateFlashcardComponent },
  { path: "answer-flashcards", component: AnswerFlashcardsComponent },
  { path: "view-all", component: ViewAllFlashcardsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
