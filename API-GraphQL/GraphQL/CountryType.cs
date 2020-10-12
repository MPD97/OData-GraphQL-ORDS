using DatabaseLibrary.Entities;
using GraphQL.Types;

namespace API_GraphQL.GraphQL
{
    public sealed class CountryType : ObjectGraphType<Country>
    {
        public CountryType()
        {
            Name = "Country";
            Field(x => x.CountryId);
            Field(x => x.CountryName);
        }
    }
}