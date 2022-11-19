using Overloading_Operator_Indexer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Operator_Indexer.Services.Interface
{
    public interface IBookservice
    {
        int GetCount(Predicate<Book> predicate);
    }
}
