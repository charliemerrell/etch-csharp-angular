using Etch.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Etch
{
    public class EtchDbContext : DbContext
    {
        public DbSet<Flashcard> Flashcards { get; set; }

        private readonly string _dbPath;

        public EtchDbContext()
        {
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            _dbPath = Path.Join(currentDirectory, "db.sqlite");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={_dbPath}");
        }
    }
}