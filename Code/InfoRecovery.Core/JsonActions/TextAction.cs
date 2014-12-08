using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Core.JsonActions
{
    public class TextAction : IJsonSerializable
    {

        public string Action { get; set; }

        public string Data { get; set; }

    }
}
