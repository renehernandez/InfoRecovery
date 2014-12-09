using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;

namespace InfoRecovery.Index.POCOs
{
    [TableName("term_document")]
    [PrimaryKey("id")]
    public class TermDocument
    {
        public int id { get; set; }
        public int term_id { get; set; }
        public int document_id { get; set; }
        public double tf { get; set; }

    }
}
