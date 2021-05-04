using System;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly POC_Context context;
        private readonly DbSet<Author> dbSet;

        public AuthorRepository(POC_Context context)
        {
            this.context = context;
            this.dbSet = this.context.Set<Author>();
        }

        public async Task AddAsync(Author author)
        {
            await this.dbSet.AddAsync(author);
        }

        public async Task<Author> GetByIdAsync(Guid id)
        {
            return this.dbSet.Include("books").FirstOrDefault(x => EF.Property<Guid>(x, "id") == id);
        }

        public async Task SaveChangeAsync()
        {
            await this.context.SaveChangesAsync();
        }
    }
}