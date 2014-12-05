using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace InfoRecovery.Core
{
    [ConfigurationCollection(typeof(ModuleConfigElement))]
    public class ModuleConfigCollection : ConfigurationElementCollection
    {

        public const string propertyName = "moduleElement";

        public override bool IsReadOnly()
        {
            return false;
        }

        public ModuleConfigElement this[int index]
        {
            get { return BaseGet(index) as ModuleConfigElement; }
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
            return new ModuleConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ModuleConfigElement)(element)).Name;
        }

    }
}
