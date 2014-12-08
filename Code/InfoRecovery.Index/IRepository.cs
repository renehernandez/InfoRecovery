using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Index
{
    interface IRepository<T> where T: class
    {
        IEnumerable<T> All();
        T Create(T instance);
        T FirstOrCreate(T instance);
        bool Exists(Dictionary<string, string> instance);
        IEnumerable<T> WhereEquals(Dictionary<string, string> fieldValues);
    }
}
