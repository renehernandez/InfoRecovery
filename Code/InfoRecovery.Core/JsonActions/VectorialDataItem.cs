using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Core.JsonActions
{
    public class VectorialDataItem
    {
        public double Idf { get; set; }

        public DocumentItem[] Documents { get; set; }
    }
}
