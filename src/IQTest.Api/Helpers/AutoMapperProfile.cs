using AutoMapper;
using IQTest.Api.Models;
using IQTest.Api.Models.User;
using IQTest.Core.Entities;

namespace IQTest.Api.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Option, OptionDto>();
            CreateMap<Question, QuestionWithoutOptionsDto>();
            CreateMap<Question, QuestionWithOptionsDto>();
            CreateMap<User, UserModel>();
            CreateMap<ContactMessageDto, ContactMessage>();
        }
    }
}
