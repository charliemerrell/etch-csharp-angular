export interface Flashcard {
    id?: number;
    prompt: string;
    correctAnswer: string;
    createdAt: string | Date;
}