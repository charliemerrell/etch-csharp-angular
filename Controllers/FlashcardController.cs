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

        [HttpGet("{flashcardId}/answers/{answerId}", Name = "GetAnswerById")]
        public ActionResult<AnswerReadDTO> GetAnswerById(int flashcardId, int answerId)
        {
            var answer = _repo.GetAnswerById(answerId);
            if (answer == null)
            {
                return NotFound();
            }
            if (answer.FlashcardId != flashcardId)
            {
                return BadRequest(); // TODO find correct response code here
            }
            return Ok(_mapper.Map<AnswerReadDTO>(answer));
        }

        [HttpPost("{id}/answers")]
        public ActionResult<AnswerReadDTO> CreateAnswerForFlashcard(int id, AnswerCreateDTO answerCreateDTO)
        {
            var flashcard = _repo.GetFlashCardById(id);
            if (flashcard == null)
            {
                return NotFound();
            }
            var answer = _mapper.Map<Answer>(answerCreateDTO);
            flashcard.Answers.Add(answer);
            _repo.SaveChanges();
            var answerReadDTO = _mapper.Map<AnswerReadDTO>(answer);
            return CreatedAtRoute(nameof(GetAnswerById), new { flashcardId = id, answerId = answerReadDTO.Id }, answerReadDTO);
        }
    }
}