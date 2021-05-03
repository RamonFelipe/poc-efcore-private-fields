using Application.DTOs;
using Domain;

namespace Application.Mappers
{
    public static class AuthorMapper
    {
        public static Author ToDomain(this AuthorDTO authorDTO)
        {
            var author = new Author();
            author.SetName(authorDTO.Name);

            foreach (var bookDTO in authorDTO.BookDTOs)
            {
                var book = new Book();
                book.SetName(bookDTO.Name);

                author.AddBook(book);
            }

            return author;
        }

        public static AuthorDTO ToDTO(this Author author)
        {
            var authorDTO = new AuthorDTO
            {
                Id = author.GetId(),
                Name = author.GetName(),
            };

            foreach (var book in author.GetBooks())
            {
                var bookDTO = new BookDTO
                {
                    Id = book.GetId(),
                    Name = book.GetName(),
                };

                authorDTO.BookDTOs.Add(bookDTO);
            }

            return authorDTO;
        }
    }
}