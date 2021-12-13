using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Etch.Models;

namespace Etch.DTOs
{
    public class FlashcardCreateDTO
    {
        [Required]
        public string Prompt { get; set; }

        [Required]
        public string CorrectAnswer { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<Answer> Answers { get; set; } = new();
    }
}