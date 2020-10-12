using System;
using AutoMapper;
using DatabaseLibrary.Entities;

namespace API_GraphQL
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Person, PersonModel>(); 
        }
    }

    public class PersonModel
    {
        public long PersonId { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        
        public short NationalityId { get; set; }
    }
}