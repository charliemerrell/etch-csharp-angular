using System.Collections.Generic;
using Etch.Models;

namespace Etch.Data 
{
    public interface IEtchRepo
    {
        public IEnumerable<Flashcard> GetAllFlashcards();
    }
}