using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;
using InfoRecovery.Index.POCOs;

namespace InfoRecovery.Index.Repositories
{
    class JsonStorageRepository: IRepository<JsonStorage>
    {
        private Database _DB;

        public JsonStorageRepository(Database db)
        {
            _DB = db;
        }
        public IEnumerable<JsonStorage> All()
        {
            return _DB.Query<JsonStorage>("SELECT * FROM 'json_storage'");
        }

        public JsonStorage Create(JsonStorage instance)
        {
            _DB.Insert(instance);
            return instance;
        }

        public JsonStorage Update(JsonStorage instance)
        {
            //In case that 'instance' doesn't exist
            var js = FirstOrCreate(instance);
            js.Value = instance.Value;
            _DB.Update(js);
            return js;
        }

        public JsonStorage FirstOrCreate(JsonStorage instance)
        {
            var entries = Where("key", "=", instance.Key);
            if (entries.Count() > 0)
                return entries.First();
            else return Create(instance);
        }

        public bool Exists(string sqlCondition)
        {
            return _DB.Exists<JsonStorage>(sqlCondition);
        }

        public IEnumerable<JsonStorage> Where(string field, string oper, string value)
        {
            return _DB.Query<JsonStorage>(string.Format("SELECT * FROM 'json_storage' WHERE {0} {1} '{2}' LIMIT 1", field, oper, value));
        }


        public void Delete(JsonStorage instance)
        {
            _DB.Execute(string.Format("DELETE FROM 'json_storage' WHERE key = '{0}'", instance.Key));
        }
    }
}
