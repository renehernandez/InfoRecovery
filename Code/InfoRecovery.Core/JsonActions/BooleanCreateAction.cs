using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Core.JsonActions
{
    public class  BooleanCreateAction : IJsonSerializable
    {

        public string Action { get; set; }

        public BooleanDataItem[] Data { get; set; }

    }
}
