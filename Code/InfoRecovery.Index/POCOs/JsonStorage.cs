using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;

namespace InfoRecovery.Index.POCOs
{
    [TableName("json_storage")]
    [PrimaryKey("id")]
    public class JsonStorage
    {
        public int id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
