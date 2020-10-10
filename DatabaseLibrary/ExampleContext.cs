using DatabaseLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLibrary
{
    public class ExampleContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Person> Persons { get; set; }

        public ExampleContext(DbContextOptions<ExampleContext> options) : base(options)
        {
        }
    }
}