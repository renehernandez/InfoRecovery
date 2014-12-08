using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Core.JsonActions
{
    public class TermItem
    {

        public double Idf { get; set; }

        public List<DocumentItem> Documents { get; set; }

    }
}
