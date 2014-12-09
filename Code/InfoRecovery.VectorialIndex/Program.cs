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

            if (args.Length > 0)
            {
                string jsonPath = args[0];
                var action = JsonHelper.ReadJson<VectorialCreateAction>(jsonPath);

                if (action.Action == "create")
                {

                    var db = new PetaPoco.Database("SqliteConn");
                    //db.Delete<Term>("");
                    Term t;
                    Document doc;

                    foreach (var item in action.Data)
                    {
                        t = new Term() { Value = item.Key, Idf = item.Value.Idf };
                        db.Insert(t);
                        foreach (var elem in item.Value.Documents)
                        {
                            doc = new Document() { Name = elem.Document };

                            if (!db.Exists<Document>("WHERE Name = @0", doc.Name))
                                db.Insert(doc);
                            else
                                doc = db.Single<Document>("WHERE Name = @0", doc.Name);

                            db.Insert("term_documents", "Id", new { TermId = t.Id, DocumentId = doc.Id, Tf = elem.Tf });
                        }
                    }
                }
            }
        }
    }
}
