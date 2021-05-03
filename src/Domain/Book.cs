using System;

namespace Domain
{
    public class Book
    {
        private Guid _id;
        private string _name;

        public Book()
        {
            this._id = Guid.NewGuid();
        }

        public void SetName(string name)
        {
            this._name = name;
        }

        public Guid GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
