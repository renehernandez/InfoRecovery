using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace InfoRecovery.Core
{
    [ConfigurationCollection(typeof(JsonConfigElement))]
    public class JsonConfigCollection : ConfigurationElementCollection
    {

        internal const string propertyName = "JsonElement";

        public override bool IsReadOnly()
        {
            return false;
        }
        
        public JsonConfigElement this[int index]
        {
            get { return BaseGet(index) as JsonConfigElement; }
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }

        protected override string ElementName
        {
            get
            {
                return propertyName;
            }
        }

        protected override bool IsElementName(string elementName)
        {
            return elementName.Equals(propertyName, StringComparison.InvariantCultureIgnoreCase);
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new JsonConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((JsonConfigElement)(element)).Name;
        }

    }
}
