using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task13.Enums;
using Task13.Interfaces;
using Task13.Models;
using Task13.Exceptions;

namespace Task13.Services
{
    class LibraryManager : ILibraryManager
    {
        private List<Book> _books;
        public List<Book> Books => _books;

        public LibraryManager()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {
            foreach (Book item in _books)
            {
                if (item.Name == book.Name)
                {
                    throw new SameBookalreadyAddedExpection("Bu adla kitab artiq elave olunub!");
                }
            }
            _books.Add(book);
        }

        public List<Book> Filter(string author, Genres genre)
        {
            List<Book> newlist = new List<Book>();

            return _books.FindAll(a => a.Author.ToUpper().Contains(author.ToUpper().Trim()) || a.Genre == genre);
        }

        public List<Book> Search(string search)
        {
            return _books.FindAll(a => (a.Name.ToUpper().Contains(search.ToUpper().Trim())) || (a.Author.ToUpper().Contains(search.ToUpper().Trim())) ||
            (a.PgaeCount.ToString().ToUpper().Contains(search.ToUpper().Trim())) || (a.Genre.ToString().ToUpper() == search.ToUpper().Trim()));
        }

        public Book ShowInfo(string name)
        {
            return _books.Find(a => (a.Name == name));
        }
    }
}
