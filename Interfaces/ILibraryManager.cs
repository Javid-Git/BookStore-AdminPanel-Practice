using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task13.Enums;
using Task13.Models;

namespace Task13.Interfaces
{
    interface ILibraryManager
    {
        public List<Book> Books { get; }
        public void Add(Book book);
        public Book ShowInfo(string name);
        public List<Book> Search(string search);
        public List<Book> Filter(string author, Genres genre);
    }
}
