using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;

namespace InfoRecovery.Index
{
    class TermRepository: IRepository<Term>
    {

        private Database _DB;
        public IEnumerable<Term> All()
        {
            return _DB.Query<Term>("SELECT * FROM 'terms'");
        }

        public Term Create(Term instance)
        {
            _DB.Insert(instance);
            return instance;
        }

        public bool Exists(Dictionary<string, string> instance)
        {
            return WhereEquals(instance).Count() > 0;
        }

        public Term FirstOrCreate(Term instance)
        {
            var terms = WhereEquals(new Dictionary<string, string> { {"value", instance.Value} } );
            if (terms.Count() > 0)
                return terms.First();
            return Create(instance);
        }

        public IEnumerable<Term> WhereEquals(Dictionary<string, string> fieldValues)
        {
            string eq = fieldValues.
                Select(x => string.Format("{0} = '{1}'", x.Key, x.Value)).
                Aggregate((x, y) => string.Format("{0} AND {1}"));
            return _DB.Query<Term>(string.Format("SELECT * FROM 'terms' WHERE {0} LIMIT 1", eq));
        }

        public TermRepository(Database db)
        {
            _DB = db;
        }

        public void AddDocument(Term term, Document document)
        {
            if (_DB.Query<TermDocument>(string.Format(
                @"SELECT * 
                      FROM 'term_document' 
                      WHERE term_id = '{0}' AND document_id = {1} 
                 LIMIT 1", term.id, document.id))
                .Count() == 0)
            {
                var td = new TermDocument
                {
                    term_id = term.id,
                    document_id = document.id
                };
                _DB.Insert(td);
            }
        }

        public IEnumerable<Document> Documents(Term term)
        {
            var t = WhereEquals(new Dictionary<string, string> { { "value", term.Value } }).First();
            var documents = _DB.Query<Document>(string.Format(
                    @"SELECT d.id, d.value 
                      FROM documents AS d 
                          INNER JOIN term_document AS td ON d.id = td.document_id 
                      WHERE td.term_id = {0}", t.id));
            return documents;
        }
    }
}
