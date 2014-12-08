using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Core.JsonActions
{
    public class VectorialCreateAction : IJsonSerializable
    {

        public string Action { get; set; }

        public List<VectorialDataItem> Data { get; set; }

    }
}
