using System;

namespace Domain
{
    public class Book
    {
        private Guid id;
        private string name;

        public Book()
        {
            this.id = Guid.NewGuid();
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
