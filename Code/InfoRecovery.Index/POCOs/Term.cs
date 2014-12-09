using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;

namespace InfoRecovery.Index.POCOs
{
    [TableName("terms")]
    [PrimaryKey("id")]
    public class Term
    {
        public int id { get; set; }
        public string Value { get; set; }
        public double Idf { get; set; }
    }
}
