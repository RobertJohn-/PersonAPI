using System.Collections.Generic;
using PersonAPI.Models;

namespace PersonAPI.Data
{
    public interface IPersonRepo
    {
        bool SaveChanges();
        IEnumerable<Person> GetAllPersons();
        Person GetPersonById(int id);
        void CreatePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(Person person);
    }
}