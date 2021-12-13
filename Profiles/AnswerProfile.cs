using AutoMapper;
using Etch.DTOs;
using Etch.Models;

namespace Etch.Profiles
{
    public class AnswerProfile : Profile
    {
        public AnswerProfile()
        {
            CreateMap<AnswerCreateDTO, Answer>();
        }
    }
}