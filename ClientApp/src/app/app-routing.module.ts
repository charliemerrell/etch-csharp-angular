import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateFlashcardComponent } from './create-flashcard/create-flashcard.component';

const routes: Routes = [{ path: "create-flashcard", component: CreateFlashcardComponent }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
