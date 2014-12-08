using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;
using System.Data.SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace InfoRecovery.Index
{
    [TableName("terms")]
    [PrimaryKey("id")]
    public class Term
    {
        public int id { get; set; }
        public string Value { get; set; }
    }

    [TableName("documents")]
    [PrimaryKey("id")]
    public class Document
    {
        public int id { get; set; }
        public string Value { get; set; }
    }

    [TableName("term_document")]
    [PrimaryKey("id")]
    public class TermDocument
    {
        public int id { get; set; }

        public int term_id { get; set; }

        public int document_id { get; set; }

    }
}
