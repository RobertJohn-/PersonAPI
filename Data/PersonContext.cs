using Microsoft.EntityFrameworkCore;
using PersonAPI.Models;

namespace PersonAPI.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> opt) : base(opt)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}