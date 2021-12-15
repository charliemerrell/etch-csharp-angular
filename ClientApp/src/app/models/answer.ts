export interface Answer {
    id?: number;
    createdAt: Date;
    isCorrect: boolean;
    flashcardId: number;
}