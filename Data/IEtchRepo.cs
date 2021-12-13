using System.Collections.Generic;
using Etch.Models;

namespace Etch.Data
{
    public interface IEtchRepo
    {
        public bool SaveChanges();
        public IEnumerable<Flashcard> GetAllFlashcards();
        public Flashcard GetFlashCardById(int id);
        public void CreateFlashcard(Flashcard flashcard);
        public Answer GetAnswerById(int id);
    }
}