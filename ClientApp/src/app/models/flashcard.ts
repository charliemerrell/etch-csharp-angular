import { Answer } from "./answer";

export interface Flashcard {
    id: number;
    prompt: string;
    correctAnswer: string;
    createdAt: Date;
    answers: Answer[];
}