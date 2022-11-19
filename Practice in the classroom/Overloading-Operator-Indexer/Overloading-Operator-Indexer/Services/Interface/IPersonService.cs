using Overloading_Operator_Indexer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Operator_Indexer.Services.Interface
{
    public interface IPersonService
    {
       List<string> GetFullData(Predicate<Person> predicate);
        int GetFilteredDatasCount(Predicate<Person> predicate);
    }
}
