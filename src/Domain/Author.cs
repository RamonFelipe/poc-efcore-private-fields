using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Author
    {
        private Guid _id;
        private string _name;
        private ICollection<Book> _books;

        public Author()
        {
            this._id = Guid.NewGuid();
            this._books = new List<Book>();
        }

        public void SetName(string name)
        {
            this._name = name;
        }

        public void AddBook(Book book)
        {
            this._books.Add(book);
        }

        public Guid GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _books.ToList();
        }
    }
}
