using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DatabaseLibrary;
using DatabaseLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_GraphQL.Services
{
    public class PersonRepository
    {
        private readonly ExampleContext _context;
        private readonly MapperConfiguration _mapperConfiguration;

        public PersonRepository(ExampleContext context, MapperConfiguration mapperConfiguration)
        {
            _context = context;
            _mapperConfiguration = mapperConfiguration;
        }

        public async Task<List<T>> GetAll<T>()
        {
            return await _context.Persons
                .Include(p => p.Nationality)
                .ProjectTo<T>(_mapperConfiguration)
                .ToListAsync();
        }
        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _context.Persons
                .Include(p => p.Nationality)
                .ToListAsync();
        }
    }
}