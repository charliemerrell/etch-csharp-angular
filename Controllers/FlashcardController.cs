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
        public ActionResult<List<FlashcardReadDTO>> GetAllFlashcards()
        {
            var flashcards = _repo.GetAllFlashcards();
            return Ok(_mapper.Map<IEnumerable<FlashcardReadDTO>>(flashcards));
        }

        [HttpGet("{id}")]
        public ActionResult<FlashcardReadDTO> GetFlashcardById(int id)
        {
            var flashcard = _repo.GetFlashCardById(id);
            if (flashcard == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<FlashcardReadDTO>(flashcard));
        }

        // TODO: make restful by returning resource and route-to
        [HttpPost]
        public ActionResult CreateFlashcard(FlashcardCreateDTO flashcardCreateDTO)
        {
            var flashcard = _mapper.Map<Flashcard>(flashcardCreateDTO);
            _repo.CreateFlashcard(flashcard);
            _repo.SaveChanges();
            return Ok();
        }

        // TODO: make restful by returning resource and route-to
        [HttpPost("{id}/answers")]
        public ActionResult CreateAnswerForFlashcard(int id, AnswerCreateDTO answerCreateDTO)
        {
            var flashcard = _repo.GetFlashCardById(id);
            if (flashcard == null)
            {
                return NotFound();
            }
            var answer = _mapper.Map<Answer>(answerCreateDTO);
            flashcard.Answers.Add(answer);
            _repo.SaveChanges();
            return Ok();
        }
    }
}