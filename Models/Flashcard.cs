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
        public DateTime RipeAfter { get; set; } = DateTime.Now + Flashcard.ProgressToRipeDelay[0];

        [Required]
        [Range(0, 5)]
        public int Progress { get; set; } = 0;

        public static Dictionary<int, TimeSpan> ProgressToRipeDelay { get; } = new Dictionary<int, TimeSpan>() {
            {0, new TimeSpan(1, 0, 0, 0)},
            {1, new TimeSpan(4, 0, 0, 0)},
            {2, new TimeSpan(16, 0, 0, 0)},
            {3, new TimeSpan(64, 0, 0, 0)},
            {4, new TimeSpan(256, 0, 0, 0)},
            {5, TimeSpan.MaxValue}
        };

        public void NewCorrectAnswer()
        {
            Progress = Math.Min(Progress + 1, 5);
            SetNewRipeAfter();
        }

        public void NewIncorrectAnswer()
        {
            Progress = Math.Max(Progress - 1, 0);
            SetNewRipeAfter();
        }

        public void SetNewRipeAfter()
        {
            RipeAfter = DateTime.Now + Flashcard.ProgressToRipeDelay[Progress];
        }
    }
}