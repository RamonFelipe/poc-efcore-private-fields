using System;
using System.Threading.Tasks;
using Domain;

namespace Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public AuthorRepository()
        {
        }

        public Task Add(Author author)
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}