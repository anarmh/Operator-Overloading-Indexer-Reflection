using Overloading_Operator_Indexer.Models;
using Overloading_Operator_Indexer.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Operator_Indexer.Services
{
    public class PersonService : IPersonService
    {
        public int GetFilteredDatasCount(Predicate<Person> predicate)
        {
            var datas = GetAll();
            var filteredDatas = datas.FindAll(predicate);
            var result = Math.Pow(filteredDatas.Count, 2);
            return (int)result;
        }

        public List<string> GetFullData(Predicate<Person> predicate)
        {
            var people = GetAll();
            var result = people.FindAll(predicate);

            return GetPersonDetails(result);


        }
        private List<Person> GetAll()
        {
            List<Person> people = new List<Person>();
            Person person1 = new Person()
            {
                Name = "Anar",
                Surname = "Huseynov",
                Address = "Sumqayit",
                Salary = 2000
            };
            Person person2 = new Person()
            {
                Name = "Cavid",
                Surname = "Rzayev",
                Address = "8mkr",
                Salary = 1000
            };
            Person person3 = new Person()
            {
                Name = "Tunar",
                Surname = "Huseynli",
                Address = "5mkr",
                Salary = 2500
            };
            Person person4 = new Person()
            {
                Name = "Elnar",
                Surname = "Huseynli",
                Address = "6mkr",
                Salary = 400
            };
            Person person5 = new Person()
            {
                Name = "Rafael",
                Surname = "Babaverdiyev",
                Address = "26-ci mehelle",
                Salary = 600
            };


            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);

            return people;

        }

        private List<string> GetPersonDetails(List<Person> people)
        {
            List<string> fullDatas = new List<string>();
            foreach (var item in people)
            {
                string data = $"{item.Name}-{item.Surname}-{item.Address}-{item.Salary}";
                fullDatas.Add(data);
            }

            return fullDatas;
        }

    }
}
