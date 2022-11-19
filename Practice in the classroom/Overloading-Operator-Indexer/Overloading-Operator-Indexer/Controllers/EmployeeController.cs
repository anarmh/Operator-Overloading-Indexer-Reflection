using Overloading_Operator_Indexer.Services;
using Overloading_Operator_Indexer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Operator_Indexer.Controllers
{
     public class EmployeeController
    {
        public static void GetEmployeeSalaryAverage()
        {
            IEmployeeService employeeService = new EmployeeService();
            Console.WriteLine(employeeService.GetAllByAverageSalary(m => m.Age > 20 && m.Age < 40));
        }
    }
}
