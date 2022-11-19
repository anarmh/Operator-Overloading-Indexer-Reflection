using Index.Models;
using System;
using System.Collections.Generic;

namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book { Name = "Xosrov ve Shirin", Author = "Nizami" };
            Book book2 = new Book { Name = "Leyli ve Mecnun", Author = "Nizami" };
            Book book3 = new Book { Name = "Yeddi Gozel", Author = "Nizami" };
            List<Library> list = new List<Library>();
            list[0] = (Library)book1;
            list[1] = (Library)book2;
            list[2] = (Library)book3;

            Console.WriteLine(list[0].Name+" "+list[0].Author);
            Console.WriteLine(list[1].Name + " " + list[1].Author);
            Console.WriteLine(list[2].Name + " " + list[2].Author);

        }
    }
}
