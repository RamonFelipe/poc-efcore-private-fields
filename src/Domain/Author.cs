using System;
using System.Collections.Generic;

namespace Domain
{
    public class Author
    {
        private Guid id;
        private string name;
        private ICollection<Book> books;

        public Author()
        {
            this.id = Guid.NewGuid();
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void AddBook(Book book)
        {
            this.books.Add(book);
        }
    }
}
