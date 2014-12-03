using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace InfoRecovery.Core
{
    public class JsonConfigElement : ConfigurationElement
    {

        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return this["name"].ToString(); }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("path", IsRequired = true)]
        public string Path {
            get { return this["path"].ToString(); }
            set { this["path"] = value; } 
        }

        public JsonConfigElement()
        {

        }

        public JsonConfigElement(string jsonName, string jsonPath)
        {
            Name = jsonName;
            Path = jsonPath;
        }

    }
}
