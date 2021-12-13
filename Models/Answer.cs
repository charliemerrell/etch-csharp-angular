using System;
using System.ComponentModel.DataAnnotations;

namespace Etch.Models
{
    public class Answer
    {
        public int Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public bool IsCorrect { get; set; }

        [Required]
        public Flashcard Flashcard { get; set; }

        [Required]
        public int FlashcardId { get; set; }
    }
}