using System.Collections.Generic;

namespace Etch.Models
{
    public class Flashcard
    {
        public int Id { get; set; }
        public string Prompt { get; set; }
        public string CorrectAnswer { get; set; }
        public List<Answer> Answers { get; set; }
    }
}