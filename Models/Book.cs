using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task13.Enums;

namespace Task13.Models
{
    class Book
    {
        public string Name;
        public string Author;
        public int PgaeCount;
        public Genres Genre;

        public Book(string name, string author, int paegcount, Genres genre)
        {
            Name = name;
            Author = author;
            PgaeCount = paegcount;
            Genre = genre;
        }
    }
}
