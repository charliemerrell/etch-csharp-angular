using System.Collections.Generic;
using Etch.Models;

namespace Etch.Data
{
    public interface IEtchRepo
    {
        bool SaveChanges();
        IEnumerable<Flashcard> GetAllFlashcards();
        Flashcard GetFlashCardById(int id);
        void CreateFlashcard(Flashcard flashcard);
        void DeleteFlashcard(Flashcard flashcard);
        IEnumerable<Flashcard> GetRipeFlashcards();
        void AddAnswer(Flashcard flashcard, bool isCorrect);
    }
}