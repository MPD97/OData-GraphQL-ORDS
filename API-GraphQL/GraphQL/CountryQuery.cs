using GraphQL;
using GraphQL.Types;

namespace API_GraphQL.GraphQL
{
    public class CountryQuery : ObjectGraphType
    {
        public CountryQuery(CountryService countryService)
        {
            int id = 0;
            Field<ListGraphType<CountryType>>(
                name: "countries",
                resolve: context => { return countryService.GetAllCountries(); });
            Field<CountryType>(
                name: "country",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> {Name = "id"}),
                resolve: context =>
                {
                    id = context.GetArgument<int>("id");
                    return countryService.GetCountryById(id);
                }
            );
            Field<ListGraphType<PersonType>>(
                name: "people",
                arguments: new QueryArguments(new
                    QueryArgument<IntGraphType> {Name = "id"}),
                resolve: context => { return countryService.GetPeopleByCountry(id); }
            );
        }
    }
}