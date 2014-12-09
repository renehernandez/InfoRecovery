using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using PetaPoco;
using InfoRecovery.Index.Repositories;
using InfoRecovery.Index.POCOs;

namespace InfoRecovery.Index
{
    class DataManager
    {
        private JsonStorageRepository _JSRepository;
        private Database _DB;
        private SQLiteConnection _DBConnection;
        private string _DataSource;
        public DataManager(string dataSource = @"database.sq3")
        {   
            _DataSource = dataSource;
            bool isNew = !System.IO.File.Exists(_DataSource);
            _DBConnection = new SQLiteConnection("Data Source=" + _DataSource);
            _DBConnection.Open();
            _DB = new Database(_DBConnection);
            if (isNew)
                CreateDB();

            _JSRepository = new JsonStorageRepository(_DB);

        }

        private void CreateDB()
        {
            _DB.Execute("CREATE TABLE json_storage (id INTEGER PRIMARY KEY AUTOINCREMENT, key STRING, value TEXT)");
        }

        public void Add(string key, string value)
        {
            _JSRepository.FirstOrCreate(new JsonStorage { Key = key, Value = value });   
        }

        public string Get(string key)
        {
            var js = _JSRepository.Where("key", "=", key);
            if (js.Count() == 0)
                throw new KeyNotFoundException(string.Format("Key {0} doesn't exist", key));
            return js.First().Value;
        }

        public void Delete(string key)
        {
            _JSRepository.Delete(new JsonStorage { Key = key });
        }

        public void Update(string key, string value)
        {
            _JSRepository.Update(new JsonStorage { Key = key, Value = value });
        }

    }
}
