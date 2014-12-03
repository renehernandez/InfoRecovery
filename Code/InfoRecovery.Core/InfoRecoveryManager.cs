using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace InfoRecovery.Core
{
    public static class InfoRecoveryManager
    {

        public static void BuildJsons()
        {
            foreach (var json in JsonElements)
            {
                TextWriter tw = new StreamWriter(string.Format("{0}\\{1}", json.Path, json.Name));
                tw.Close();
            }
        }

        public static InfoRecoverySection InfoConfig
        {
            get { return (InfoRecoverySection)ConfigurationManager.GetSection("infoSection"); }
        }

        public static JsonConfigCollection JsonCollection
        {
            get { return InfoConfig.JsonCollection; }
        }

        public static IEnumerable<JsonConfigElement> JsonElements
        {
            get
            {
                foreach (JsonConfigElement json in JsonCollection)
                {
                    if (json != null)
                        yield return json;
                }
            }
        }

    }
}
