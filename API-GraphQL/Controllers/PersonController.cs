using System.Collections.Generic;
using System.Threading.Tasks;
using API_GraphQL.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_GraphQL.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly PersonRepository _personRepository;

        public PersonController(PersonRepository personRepository)
        {
            _personRepository = personRepository;
        }


        [HttpGet("[action]")]
        public async Task<List<PersonModel>> List()
        {
            return await _personRepository.GetAll<PersonModel>();
        }
    }
}