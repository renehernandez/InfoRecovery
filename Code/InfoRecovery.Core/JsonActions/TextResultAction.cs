using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Core.JsonActions
{
    public class TextResultAction : IJsonSerializable
    {
        public string  Action { get; set; }

        public string[] Terms { get; set; }

    }
}
