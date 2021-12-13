using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Etch.Models
{
    public class Flashcard
    {
        public int Id { get; set; }

        [Required]
        public string Prompt { get; set; }

        [Required]
        public string CorrectAnswer { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public List<Answer> Answers { get; set; } = new();
    }
}