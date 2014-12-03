﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace InfoRecovery.Core
{
    public class InfoRecoverySection : ConfigurationSection
    {
        [ConfigurationProperty("jsonCollection")]
        public JsonConfigCollection JsonCollection
        {
            get { return ((JsonConfigCollection)(base["jsonCollection"])); }
            set { base["jsonCollection"] = value; }
        }
    }
}
