using InfoRecovery.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Visual.JsonSerializables
{
    public class BuildAction : IJsonSerializable
    {
        public string Action { get; set; }

        public string Data { get; set; }

        public BuildAction()
        {
            Action = "build";
        }
        
    }
}
