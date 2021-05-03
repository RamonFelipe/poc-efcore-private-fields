using System;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Mappers;
using Application.Services.Interfaces;
using Domain.Repositories;

namespace Application.Services.Implementations
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public async Task<Guid> Create(AuthorDTO authorDTO)
        {
            var author = authorDTO.ToDomain();

            await this.authorRepository.AddAsync(author);
            await this.authorRepository.SaveChangeAsync();

            return author.GetId();
        }

        public async Task<AuthorDTO> GetBy(Guid id)
        {
            var author = await this.authorRepository.GetByIdAsync(id);

            return author.ToDTO();
        }
    }
}