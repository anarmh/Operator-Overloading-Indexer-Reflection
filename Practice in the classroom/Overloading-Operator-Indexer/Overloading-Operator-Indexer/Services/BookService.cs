using Overloading_Operator_Indexer.Models;
using Overloading_Operator_Indexer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Operator_Indexer.Services
{
    public class BookService : IBookservice
    {
        public int GetCount(Predicate<Book> predicate)
        {
            var books = GetAll();
            return books.FindAll(predicate).Count;
        }

        private List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            Book book1 = new Book()
            {
                Name = "Isgendarname",
                Author = "Nizami"
            };
            Book book2 = new Book()
            {
                Name = "Shikayetname",
                Author = "Fuzuli"
            };
            Book book3 = new Book()
            {
                Name = "Ferhad ve Shirin",
                Author = "Nizami"
            };
            Book book4 = new Book()
            {
                Name = "Xosrov ve Shirin",
                Author = "Nizami"
            };
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);

            return books;

        }
    }
}
