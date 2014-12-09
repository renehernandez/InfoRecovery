using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.VectorialIndex.POCOs
{
    [TableName("term_documents")]
    [PrimaryKey("Id", autoIncrement = true)]
    public class TermDocument
    {
        public int Id { get; set; }

        public int TermId { get; set; }

        public int DocumentId { get; set; }

        public double Tf { get; set; }

    }
}
