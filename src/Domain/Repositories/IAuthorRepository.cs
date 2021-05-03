using System;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IAuthorRepository
    {
        Task AddAsync(Author author);
        Task<Author> GetByIdAsync(Guid id);
        Task SaveChangeAsync();
    }
}