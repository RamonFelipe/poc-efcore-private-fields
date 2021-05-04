using System;
using System.Collections.Generic;
using System.Linq;

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
            this.books = new List<Book>();
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void AddBook(Book book)
        {
            this.books.Add(book);
        }

        public Guid GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public IEnumerable<Book> GetBooks()
        {
            return books.ToList();
        }
    }
}
