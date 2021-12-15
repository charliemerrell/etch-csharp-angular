using System.Collections.Generic;
using AutoMapper;
using Etch.Data;
using Etch.DTOs;
using Etch.Models;
using Microsoft.AspNetCore.Mvc;

namespace Etch.Controllers
{
    [Route("api/flashcards")]
    [ApiController]
    public class FlashcardController : ControllerBase
    {
        private readonly IEtchRepo _repo;
        private readonly IMapper _mapper;

        public FlashcardController(IEtchRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<FlashcardReadDTO>> GetAllFlashcards(string ripe)
        {
            IEnumerable<Flashcard> flashcards;
            if (ripe == "true")
            {
                flashcards = _repo.GetRipeFlashcards();
            }
            else
            {
                flashcards = _repo.GetAllFlashcards();
            }
            return Ok(_mapper.Map<IEnumerable<FlashcardReadDTO>>(flashcards));
        }

        [HttpGet("{id}", Name = "GetFlashcardById")]
        public ActionResult<FlashcardReadDTO> GetFlashcardById(int id)
        {
            var flashcard = _repo.GetFlashCardById(id);
            if (flashcard == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<FlashcardReadDTO>(flashcard));
        }

        [HttpPost]
        public ActionResult<FlashcardReadDTO> CreateFlashcard(FlashcardCreateDTO flashcardCreateDTO)
        {
            var flashcard = _mapper.Map<Flashcard>(flashcardCreateDTO);
            _repo.CreateFlashcard(flashcard);
            _repo.SaveChanges();
            var flashcardReadDTO = _mapper.Map<FlashcardReadDTO>(flashcard);
            return CreatedAtRoute(nameof(GetFlashcardById), new { Id = flashcardReadDTO.Id }, flashcardReadDTO);
        }

        [HttpPost("{id}/answers")]
        public ActionResult CreateAnswerForFlashcard(int id, AnswerCreateDTO answerCreateDTO)
        {
            var flashcard = _repo.GetFlashCardById(id);
            if (flashcard == null)
            {
                return NotFound();
            }
            _repo.AddAnswer(flashcard, answerCreateDTO.IsCorrect);
            _repo.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteFlashcardById(int id)
        {
            var flashcard = _repo.GetFlashCardById(id);
            if (flashcard == null)
            {
                return NotFound();
            }
            _repo.DeleteFlashcard(flashcard);
            _repo.SaveChanges();
            return NoContent();
        }
    }
}