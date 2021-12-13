using System.Collections.Generic;
using System.Linq;
using Etch.Models;

namespace Etch.Data
{
    public class SqlEtchRepo : IEtchRepo
    {
        private readonly EtchDbContext _context;

        public SqlEtchRepo(EtchDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Flashcard> GetAllFlashcards()
        {
            return _context.Flashcards.ToList();
        }
    }
}