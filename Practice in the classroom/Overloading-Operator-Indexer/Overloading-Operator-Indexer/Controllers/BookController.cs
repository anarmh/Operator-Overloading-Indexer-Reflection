using Overloading_Operator_Indexer.Services;
using Overloading_Operator_Indexer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Operator_Indexer.Controllers
{
    public class BookController
    {
        public static void GetCount()
        {
            IBookservice bookService = new BookService();
            Console.WriteLine(bookService.GetCount(m=>m.Author=="Nizami"));
        }
    }
}
