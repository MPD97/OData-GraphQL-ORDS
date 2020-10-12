﻿using DatabaseLibrary.Entities;
using GraphQL.Types;

namespace API_GraphQL.GraphQL
{
    public sealed class PersonType : ObjectGraphType<Person>
    {
        public PersonType()
        {
            Field(x => x.PersonId);
            Field(x => x.FirstName);
            Field(x => x.SecondName);
            Field(x => x.LastName);
            Field(x => x.BirthDate);
            Field<GenderType>(nameof(Person.Gender));
            Field(x => x.NationalityId);
        }

        public class GenderType : EnumerationGraphType<Gender>
        {
        }
    }
}