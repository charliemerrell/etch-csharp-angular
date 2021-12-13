using System;
using System.ComponentModel.DataAnnotations;

namespace Etch.Models
{
    public class AnswerCreateDTO
    {
        [Required]
        public bool IsCorrect { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}