using System;

namespace Etch.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsCorrect { get; set; }
        public Flashcard Flashcard { get; set; }
        public int FlashcardId { get; set; }
    }
}