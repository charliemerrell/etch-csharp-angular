using System.Collections.Generic;
using System.Linq;
using Etch.Models;
using System;
using Microsoft.EntityFrameworkCore;

namespace Etch.Data
{
    public class SqlEtchRepo : IEtchRepo
    {
        private readonly EtchDbContext _context;

        public SqlEtchRepo(EtchDbContext context)
        {
            _context = context;
        }

        public void AddAnswer(Flashcard flashcard, bool isCorrect)
        {
            if (isCorrect)
            {
                flashcard.NewCorrectAnswer();
            }
            else
            {
                flashcard.NewIncorrectAnswer();
            }
        }

        public void CreateFlashcard(Flashcard flashcard)
        {
            if (flashcard == null)
            {
                throw new ArgumentNullException();
            }
            _context.Flashcards.Add(flashcard);
        }

        public void DeleteFlashcard(Flashcard flashcard)
        {
            _context.Flashcards.Remove(flashcard);
        }

        public IEnumerable<Flashcard> GetAllFlashcards()
        {
            return _context.Flashcards.ToList();
        }

        public Flashcard GetFlashCardById(int id)
        {
            return _context.Flashcards.FirstOrDefault(flashcard => flashcard.Id == id);
        }

        public IEnumerable<Flashcard> GetRipeFlashcards()
        {
            return _context.Flashcards.Where(flashcard => flashcard.RipeAfter < DateTime.Now).ToList();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}