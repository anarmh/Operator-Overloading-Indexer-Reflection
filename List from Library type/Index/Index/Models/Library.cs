using System;
using System.Collections.Generic;
using System.Text;

namespace Index.Models
{
   public class Library
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public List<Book>[] _books;

        public Library(int size = 10)
        {
            _books = new List<Book>[size];
        }
        public List<Book> this[int index]
        {
            get
            {
                return _books[index];
            }
            set
            {
                _books[index] = value;
            }
        }

        public static explicit operator Library(Book book)
        {
            Library library = new Library();
            library.Name = book.Name.ToString();
            library.Author = book.Author.ToString();
            return library;
        }
    }
}
