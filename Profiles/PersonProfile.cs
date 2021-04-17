using AutoMapper;
using PersonAPI.Dtos;
using PersonAPI.Models;

namespace PersonAPI.Profiles
{
    public class PersonsProfiles : Profile
    {
        public PersonsProfiles()
        {
            CreateMap<Person, PersonReadDto>();
            CreateMap<PersonCreateDto, Person>();
            CreateMap<PersonUpdateDto, Person>();
        }
    }
}