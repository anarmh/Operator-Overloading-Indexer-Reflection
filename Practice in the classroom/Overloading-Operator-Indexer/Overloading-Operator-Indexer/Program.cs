using Overloading_Operator_Indexer.Controllers;
using Overloading_Operator_Indexer.Models;
using Overloading_Operator_Indexer.Services;
using Overloading_Operator_Indexer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Overloading_Operator_Indexer
{
  public  class Program
    {
        static void Main(string[] args)
        {
            //PersonController.GetPersonDatas();
            //BookController.GetCount();
            //EmployeeController.GetEmployeeSalaryAverage();
            //Console.WriteLine(GetBook());
            //PersonController.GetFilteredpersonPowCount();



            //Person person1 = new Person();
            //person1.Age=18;
            //Person person2 = new Person();
            //person2.Age=20;
            //Console.WriteLine( person1>person2);

            //List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            //Console.WriteLine(nums[1]);

            Book book1 = new Book { Name = "Xosrov1", Author = "Nizami1" };
            Book book2 = new Book { Name = "Xosrov2", Author = "Nizami2" };
            Book book3 = new Book { Name = "Xosrov3", Author = "Nizami3" };
            Library library = new Library();
            library[0] = book1;
            library[1] = book2;
            library[2] = book3;

            Console.WriteLine(library[0].Name + " " + library[0].Author); ;

            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (var item in assembly.GetTypes())
            {
                foreach (var item2 in item.GetMembers())
                {
                    Console.WriteLine(item2);
                }
            }

        }

        //static Book GetBook()
        //{
        //    Book book = new Book { Name = "Xosrov", Author = "Nizami" };
        //    return book;
        //}





    }
}
