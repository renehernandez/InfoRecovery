using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Index.Repositories
{
    interface IRepository<T> where T: class
    {
        IEnumerable<T> All();
        T Create(T instance);
        T FirstOrCreate(T instance);
        T Update(T instance);
        bool Exists(string sqlCondition);
        IEnumerable<T> Where(string field, string oper, string value);
        void Delete(T instance);

    }
}
