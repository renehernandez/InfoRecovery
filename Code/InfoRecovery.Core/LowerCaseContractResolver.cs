using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Core
{
    public class LowerCaseContractResolver : DefaultContractResolver
    {

        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToLower();
        }

    }
}
