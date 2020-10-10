using System;
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

            modelBuilder.Entity<Country>().HasData(new Country[]
            {
                new Country()
                {
                    CountryId = 1,
                    CountryName = "Poland"
                },
                new Country()
                {
                    CountryId = 2,
                    CountryName = "Germany"
                },
                new Country()
                {
                    CountryId = 3,
                    CountryName = "Russia"
                },
                new Country()
                {
                    CountryId = 4,
                    CountryName = "France"
                },
                new Country()
                {
                    CountryId = 5,
                    CountryName = "Denmark"
                },
            });

            modelBuilder.Entity<Person>().HasData(new Person[]
            {
                new Person()
                {
                    PersonId = 1,
                    Gender = Gender.Male,
                    BirthDate = DateTimeOffset.Now.AddYears(-68).AddDays(3),
                    FirstName = "Antoni",
                    SecondName = null,
                    LastName = "Muller",
                    NationalityId = 2
                },
                new Person()
                {
                    PersonId = 2,
                    Gender = Gender.Female,
                    BirthDate = DateTimeOffset.Now.AddYears(-19).AddDays(88),
                    FirstName = "Helga",
                    SecondName = "Petra",
                    LastName = "Von Treskow",
                    NationalityId = 2
                },
                new Person()
                {
                    PersonId = 3,
                    Gender = Gender.Male,
                    BirthDate = DateTimeOffset.Now.AddYears(-56).AddDays(4),
                    FirstName = "Antoni",
                    SecondName = "Władysław",
                    LastName = "Szewczyk",
                    NationalityId = 1
                },
                new Person()
                {
                    PersonId = 4,
                    Gender = Gender.Female,
                    BirthDate = DateTimeOffset.Now.AddYears(-36).AddDays(4),
                    FirstName = "Katarzyna",
                    SecondName = null,
                    LastName = "Kowal",
                    NationalityId = 1
                },
                
                new Person()
                {
                    PersonId = 5,
                    Gender = Gender.Male,
                    BirthDate = DateTimeOffset.Now.AddYears(-21).AddDays(-124),
                    FirstName = "Николай",
                    SecondName = "Иван",
                    LastName = "Лебедев",
                    NationalityId = 3
                },
                new Person()
                {
                    PersonId = 6,
                    Gender = Gender.Female,
                    BirthDate = DateTimeOffset.Now.AddYears(-33).AddDays(-13),
                    FirstName = "Галина",
                    SecondName = "Нина",
                    LastName = "Соколов",
                    NationalityId = 3
                },
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}