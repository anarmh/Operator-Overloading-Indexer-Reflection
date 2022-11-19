using Overloading_Operator_Indexer.Services;
using Overloading_Operator_Indexer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Operator_Indexer.Controllers
{
    public class PersonController
    {
        public static void GetPersonDatas()
        {
            IPersonService personService = new PersonService();

            var result = personService.GetFullData(m => m.Salary > 1000);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static void GetFilteredpersonPowCount()
        {
            IPersonService personService = new PersonService();
            string word = "C";
            Console.WriteLine(personService.GetFilteredDatasCount(m=>m.Name.ToLower().StartsWith(word.ToLower())));
        }
    }
}

