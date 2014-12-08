using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;

namespace InfoRecovery.Index
{
    class DocumentRepository : IRepository<Document>
    {
        private Database _DB;

        public DocumentRepository(Database db)
        {
            _DB = db;
        }
        public IEnumerable<Document> All()
        {
            return _DB.Query<Document>("SELECT * FROM 'documents'");
        }

        public Document Create(Document instance)
        {
            _DB.Insert(instance);
            return instance;
        }

        public Document FirstOrCreate(Document instance)
        {
            var documents = WhereEquals(new Dictionary<string, string> { { "value", instance.Value } });
            if (documents.Count() > 0)
                return documents.First();
            return Create(instance);
        }

        public bool Exists(Dictionary<string, string> instance)
        {
            return WhereEquals(instance).Count() > 0;
        }

        public IEnumerable<Document> WhereEquals(Dictionary<string, string> fieldValues)
        {
            string eq = fieldValues.
                Select(x => string.Format("{0} = '{1}'", x.Key, x.Value)).
                Aggregate((x, y) => string.Format("{0} AND {1}"));
            return _DB.Query<Document>(string.Format("SELECT * FROM 'documents' WHERE {0} LIMIT 1", eq));
        }
    }
}
