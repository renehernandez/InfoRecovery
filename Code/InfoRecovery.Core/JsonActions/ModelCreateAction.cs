using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Core.JsonActions
{
    public class ModelCreateAction : IJsonSerializable
    {

        public string Action { get; set; }

        public List<ModelData> Data { get; set; }

    }
}
