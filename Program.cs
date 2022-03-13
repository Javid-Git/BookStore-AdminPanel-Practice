using System;
using Task13.Models;
using Task13.Interfaces;
using Task13.Services;
using Task13.Enums;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kitab";
            string author = "Muellif";
            int pagecount = 130;
            Genres genre = Genres.detective;
            Book book = new Book(name, author, pagecount, genre);

            LibraryManager manager = new LibraryManager();
            manager.Add(book);
            manager.Filter("if", genre);
        }
    }
}
