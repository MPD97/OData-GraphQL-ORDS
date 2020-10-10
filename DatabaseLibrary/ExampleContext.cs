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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().Property(c => c.CountryName)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Person>().Property(p => p.FirstName)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Person>().Property(p => p.SecondName)
                .HasMaxLength(100)
                .IsRequired(false);
            modelBuilder.Entity<Person>().Property(p => p.LastName)
                .HasMaxLength(150)
                .IsRequired();
            
            base.OnModelCreating(modelBuilder);
            
        }
    }
}