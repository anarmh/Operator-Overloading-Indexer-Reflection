using Overloading_Operator_Indexer.Controllers;
using Overloading_Operator_Indexer.Models;
using Overloading_Operator_Indexer.Services;
using Overloading_Operator_Indexer.Services.Interface;
using System;

namespace Overloading_Operator_Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonController.GetPersonDatas();
            //BookController.GetCount();
            //EmployeeController.GetEmployeeSalaryAverage();
            Console.WriteLine(GetBook());
        }

        static Book GetBook()
        {
            Book book = new Book { Name = "Xosrov", Author = "Nizami" };
            return book;


        }
    }
}
