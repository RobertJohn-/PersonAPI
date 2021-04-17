using System;
using System.Collections.Generic;
using System.Linq;
using PersonAPI.Models;

namespace PersonAPI.Data
{
    public class SqlPersonRepo : IPersonRepo
    {
        private readonly PersonContext _context;

        public SqlPersonRepo(PersonContext context)
        {
            _context = context;
        }

        public void CreatePerson(Person person)
        {
            if(person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }
            
            _context.Persons.Add(person);
        }

        public void DeletePerson(Person person)
        {
            if(person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }

            _context.Persons.Remove(person);
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _context.Persons.ToList();
        }

        public Person GetPersonById(int id)
        {
            return _context.Persons.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0);
        }

        public void UpdatePerson(Person person)
        {
            //Nothing
        }
    }
}