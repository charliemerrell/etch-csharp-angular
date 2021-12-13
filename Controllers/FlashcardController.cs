using System.Collections.Generic;
using Etch.Data;
using Etch.Models;
using Microsoft.AspNetCore.Mvc;

namespace Etch.Controllers
{
    [Route("api/flashcards")]
    [ApiController]
    public class FlashcardController : ControllerBase
    {
        private readonly IEtchRepo _repo;

        public FlashcardController(IEtchRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Flashcard>> GetAllFlashcards()
        {
            return Ok(_repo.GetAllFlashcards());
        }

        // TODO: make restful by returning resource and route-to
        [HttpPost]
        public ActionResult CreateFlashcard(Flashcard flashcard)
        {
            if (flashcard == null)
            {
                return NotFound();
            }
            _repo.CreateFlashcard(flashcard);
            _repo.SaveChanges();
            return Ok();
        }
    }
}