using System.Collections.Generic;
using System.Linq;
using Etch.Models;
using System;

namespace Etch.Data
{
    public class SqlEtchRepo : IEtchRepo
    {
        private readonly EtchDbContext _context;

        public SqlEtchRepo(EtchDbContext context)
        {
            _context = context;
        }

        public void CreateFlashcard(Flashcard flashcard)
        {
            if (flashcard == null)
            {
                throw new ArgumentNullException();
            }
            _context.Flashcards.Add(flashcard);
        }

        public IEnumerable<Flashcard> GetAllFlashcards()
        {
            return _context.Flashcards.ToList();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}