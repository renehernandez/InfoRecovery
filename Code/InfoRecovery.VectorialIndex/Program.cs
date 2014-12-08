using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoRecovery.Core;
using InfoRecovery.Core.JsonActions;
using System.Configuration;
using InfoRecovery.VectorialIndex.POCOs;

namespace InfoRecovery.VectorialIndex
{
    class Program
    {
        static void Main(string[] args)
        {

            //string jsonPath = args[0];
            //var action = JsonHelper.ReadJson<VectorialCreateAction>(jsonPath);

            var db = new PetaPoco.Database("SqliteConn");
            db.Insert(new Term() { Idf = 10.5, Value ="precious" });
            foreach (var item in db.Query<Term>("Select * From terms"))
            {
                Console.WriteLine("Value = {0}; Idf = {1}", item.Value, item.Idf);
            }
        }
    }
}
