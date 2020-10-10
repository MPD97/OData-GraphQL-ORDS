using System;

namespace DatabaseLibrary.Entities
{
    public class Person
    {
        public long PersonId { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        
        public Country Nationality { get; set; }
        public short NationalityId { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Unknown
    }
}