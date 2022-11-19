using Overloading_Operator_Indexer.Models;
using Overloading_Operator_Indexer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overloading_Operator_Indexer.Services
{
    public class EmployeeService : IEmployeeService
    {
        public double GetAllByAverageSalary(Predicate<Employee> predicate)
        {
            var employees = GetAll();
            var result = employees.FindAll(predicate);
            return CalculateAverage(result);
        }

        private double CalculateAverage(List<Employee> employees)
        {
            return employees.Average(m => m.Salary);
        }

        private List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Age = 20, Salary = 2000 });
            employees.Add(new Employee { Age = 25, Salary = 1000 });
            employees.Add(new Employee { Age = 30, Salary = 4000 });

            return employees;
        }
    }
}
