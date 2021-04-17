using System.Collections.Generic;
using PersonAPI.Models;

namespace PersonAPI.Data
{
    public class MockPersonRepo : IPersonRepo
    {
        public void CreatePerson(Person person)
        {
            throw new System.NotImplementedException();
        }

        public void DeletePerson(Person person)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Person> GetAllPersons()
        {
            var persons = new List<Person>
            {
                new Person{Id = 0, FName = "Bert", LName = "Mill"},
                new Person{Id = 1, FName = "Dea", LName = "Mill"},
                new Person{Id = 2, FName = "Jon", LName = "Rey"},
            };

            return persons;
        }

        public Person GetPersonById(int id)
        {
            return new Person{Id = 0, FName = "Bert", LName = "Mill"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePerson(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}