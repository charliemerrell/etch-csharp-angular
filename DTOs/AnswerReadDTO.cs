using System;
using System.ComponentModel.DataAnnotations;

namespace Etch.DTOs
{
    public class AnswerReadDTO
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsCorrect { get; set; }

        public int FlashcardId { get; set; }
    }
}