using System;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<Guid> Create(AuthorDTO authorDTO);
        Task<AuthorDTO> GetBy(Guid id);
    }
}