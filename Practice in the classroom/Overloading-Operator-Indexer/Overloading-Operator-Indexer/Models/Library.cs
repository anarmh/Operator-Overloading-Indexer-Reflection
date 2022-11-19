using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Operator_Indexer.Models
{
   public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Book[] _books;

        public Library(int size=100)
        {
            _books = new Book[size];
        }
        public Book this [int index]
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
    }
}
