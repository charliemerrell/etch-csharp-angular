using AutoMapper;
using Etch.DTOs;
using Etch.Models;

namespace Etch.Profiles
{
    public class FlashcardProfile : Profile
    {
        public FlashcardProfile()
        {
            CreateMap<Flashcard, FlashcardReadDTO>();
            CreateMap<FlashcardCreateDTO, Flashcard>();
        }
    }
}