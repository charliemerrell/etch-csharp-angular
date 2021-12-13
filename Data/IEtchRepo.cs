using System.Collections.Generic;
using Etch.Models;

namespace Etch.Data
{
    public interface IEtchRepo
    {
        public bool SaveChanges();
        public IEnumerable<Flashcard> GetAllFlashcards();
        public void CreateFlashcard(Flashcard flashcard);
    }
}