using System;
using System.ComponentModel.DataAnnotations;

namespace Etch.Models
{
    public class AnswerCreateDTO
    {
        [Required]
        public bool IsCorrect { get; set; }
    }
}