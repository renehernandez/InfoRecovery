using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.VectorialIndex.POCOs
{
    [TableName("documents")]
    [PrimaryKey("Id", autoIncrement = true)]
    public class Document
    {

        public int Id { get; set; }

        public string Name { get; set; }

    }
}
