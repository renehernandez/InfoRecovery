using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace InfoRecovery.Core
{
    public class JsonConfigElement : ConfigurationElement
    {

        [ConfigurationProperty("name", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string Name
        {
            get { return this["name"].ToString(); }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("path", DefaultValue = "", IsKey = false, IsRequired = true)]
        public string Path {
            get { return this["path"].ToString(); }
            set { this["path"] = value; } 
        }

        public JsonConfigElement()
        {

        }

    }
}
