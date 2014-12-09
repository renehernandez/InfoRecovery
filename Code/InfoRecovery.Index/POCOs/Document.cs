using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;

namespace InfoRecovery.Index.POCOs
{
    [TableName("documents")]
    [PrimaryKey("id")]
    public class Document
    {
        public int id { get; set; }
        public string Value { get; set; }
    }
}
