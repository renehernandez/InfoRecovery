using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Core.JsonActions
{
    public class BooleanDataItem
    {

        public string Key { get; set; }

        public List<string> Value { get; set; }

        public BooleanDataItem(string key, string init)
        {
            Key = key;
            Value = new List<string>();
            Value.Add(init);
        }

    }
}
