using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Core.JsonActions
{
    public class ReportAction : IJsonSerializable
    {

        public string Action { get; set; }

        public bool Success { get; set; }

        public DocumentMatch[] Results { get; set; }

    }
}
