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
        public TermRepository TermRepository {get; private set;}
        public DocumentRepository DocumentRepository { get; private set; }
        public Database DB { get; private set; }
        public SQLiteConnection DBConnection { get; private set; }
        public string DataSource { get; private set; }
        public DataManager(string dataSource = @"database.sq3")
        {
            DataSource = dataSource;
            bool isNew = !System.IO.File.Exists(DataSource);
            DBConnection = new SQLiteConnection("Data Source=" + DataSource);
            DBConnection.Open();
            DB = new Database(DBConnection);
            if (isNew)
                CreateDB();

            TermRepository = new TermRepository(DB);
            DocumentRepository = new DocumentRepository(DB);
            

        }

        private void CreateDB()
        {
            DB.Execute("CREATE TABLE terms (id INTEGER PRIMARY KEY AUTOINCREMENT, value STRING, idf DOUBLE)");
            DB.Execute("CREATE TABLE documents (id INTEGER PRIMARY KEY AUTOINCREMENT, value STRING)");
            DB.Execute("CREATE TABLE term_document (id INTEGER PRIMARY KEY AUTOINCREMENT, term_id INTEGER, document_id INTEGER, tf DOUBLE)");
        }

        public void Add(string term, string document)
        {

            Term t = TermRepository.FirstOrCreate(new Term { Value = term });
            Document d = DocumentRepository.FirstOrCreate(new Document { Value = document });
            TermRepository.AddDocument(t, d);
            
        }

        public IEnumerable<string> Get(string term)
        {
            var documents = TermRepository.Documents(new Term { Value = term });
            return documents.Select(d => d.Value);
        }

        public void Delete(string term)
        {
            TermRepository.Delete(new Term { Value = term });
        }

        public void Update(string term, string document)
        {   
            var t = new Term { Value = term };
            var d = new Document { Value = term };
            //DB.Update()
            //DB.Insert(t);
            //DB.Insert()
        }

    }
}
