using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Core.JsonActions
{
    public class ModelAction : IJsonSerializable
    {
        public string Action { get; set; }

        public string Path { get; set; }

        public string Query { get; set; }

        public int Count { get; set; }
    }
}
