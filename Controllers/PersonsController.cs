using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonAPI.Data;
using PersonAPI.Dtos;
using PersonAPI.Models;

namespace PersonAPI.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepo _repository;
        public IMapper _mapper { get; }




        public PersonsController(IPersonRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // private readonly MockPersonRepo _repository = new MockPersonRepo();




        [HttpGet]
        public ActionResult <IEnumerable<PersonReadDto>> GetAllPersons()
        {
            var personItems = _repository.GetAllPersons();

            return Ok(_mapper.Map<IEnumerable<PersonReadDto>>(personItems));
        }




        [HttpGet("{id}", Name = "GetPersonById")]
        public ActionResult <PersonReadDto> GetPersonById(int id)
        {
            var personItem = _repository.GetPersonById(id);
            if(personItem != null)
            {
                return Ok(_mapper.Map<PersonReadDto>(personItem));
            }
            return NotFound();
        }



        [HttpPost]
        public ActionResult <PersonReadDto> CreatePerson(PersonCreateDto personCreateDto)
        {
            var personModel = _mapper.Map<Person>(personCreateDto);
            _repository.CreatePerson(personModel);
            _repository.SaveChanges();

            var personReadDto = _mapper.Map<PersonReadDto>(personModel);
            
            return CreatedAtRoute(nameof(GetPersonById), new {Id = personReadDto.Id}, personReadDto);
        }



        [HttpPut("{id}")]
        public ActionResult <PersonUpdateDto> UpdatePerson(int id, PersonUpdateDto personUpdateDto)
        {
            var personModelFromRepo = _repository.GetPersonById(id);
            if(personModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(personUpdateDto, personModelFromRepo);
            _repository.UpdatePerson(personModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }



        [HttpDelete("{id}")]
        public ActionResult DeletePerson(int id)
        {
            var personModelFromRepo = _repository.GetPersonById(id);
            if(personModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeletePerson(personModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}