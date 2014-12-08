using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.VectorialIndex.POCOs
{
    [TableName("terms")]
    [PrimaryKey("Id", autoIncrement = true)]
    public class Term
    {

        public int Id { get; set; }

        public string Value { get; set; }

        public double Idf { get; set; }

    }
}
