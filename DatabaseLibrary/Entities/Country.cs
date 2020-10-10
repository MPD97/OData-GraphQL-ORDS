using System.Collections.Generic;

namespace DatabaseLibrary.Entities
{
    public class Country
    {
        public short CountryId { get; set; }
        public string CountryName { get; set; }

        public ICollection<Person> Citizenship { get; set; }
    }
}