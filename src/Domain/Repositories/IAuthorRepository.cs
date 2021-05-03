using Domain;
using System;
using System.Threading.Tasks;

public interface IAuthorRepository
{
    Task Add(Author author);
    Task<Author> GetById(Guid id);
}