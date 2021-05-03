using System;
using System.Collections.Generic;

namespace Application.DTOs
{
    public class AuthorDTO
    {
        public AuthorDTO()
        {
            BookDTOs = new List<BookDTO>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<BookDTO> BookDTOs { get; set; }
    }
}