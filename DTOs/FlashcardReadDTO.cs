using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Etch.Models;

namespace Etch.DTOs
{
    public class FlashcardReadDTO
    {
        public int Id { get; set; }

        public string Prompt { get; set; }

        public string CorrectAnswer { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<Answer> Answers { get; set; } = new();
    }
}