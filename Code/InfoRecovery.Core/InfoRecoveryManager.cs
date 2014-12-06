using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace InfoRecovery.Core
{
    public static class InfoRecoveryManager
    {

        public static Configuration Configuration { get; private set; }

        public static string ConfigurationPath { get; private set; }


        static InfoRecoveryManager()
        {
            SetConfiguration();
        }

        private static void SetConfiguration()
        {
            ConfigurationPath = Assembly.GetEntryAssembly().Location;
            if (!File.Exists(String.Concat(ConfigurationPath, ".config")))
                CreateAppConfig();

            Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }


        public static void CreateAppConfig()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sb.AppendLine("<configuration>");
            sb.AppendLine("<configSections>");
            sb.AppendLine(string.Format("<section name={0}infoSection{0} type={0}InfoRecovery.Core.InfoRecoverySection, InfoRecovery.Core{0}/>", '\"'));
            sb.AppendLine("</configSections>");
            sb.AppendLine("</configuration>");

            System.IO.File.WriteAllText(String.Concat(ConfigurationPath, ".config"), sb.ToString());
        }

        public static void BuildConfigurations()
        {
            if (InfoConfig.JsonElement == null)
            {
                InfoConfig.JsonElement = new JsonConfigElement() { Name = "Message", Path = "." };
            }

            if (InfoConfig.ModuleCollection == null)
                InfoConfig.ModuleCollection = new ModuleConfigCollection();

            if (InfoConfig.ModuleCollection.Count == 0)
            {
                var collection = InfoConfig.ModuleCollection;

                collection.Add(new ModuleConfigElement() { Name = "Text", Path = "..\\..\\..\\InfoRecovery.Text\\bin\\Debug\\InfoRecovery.Text.exe" });
                collection.Add(new ModuleConfigElement() { Name = "Index", Path = "..\\..\\..\\InfoRecovery.Index\\bin\\Debug\\InfoRecovery.Index.exe" });
                collection.Add(new ModuleConfigElement() { Name = "Model", Path = "..\\..\\..\\InfoRecovery.BooleanModel\\bin\\Debug\\InfoRecovery.BooleanModel.exe" });
            }

            Configuration.Save();
            ConfigurationManager.RefreshSection("infoSection");
        }

        public static void CreateJson()
        {
            TextWriter tw = new StreamWriter(string.Format("{0}\\{1}.json", InfoConfig.JsonElement.Path, InfoConfig.JsonElement.Name));
            tw.Close();
        }

        public static InfoRecoverySection InfoConfig
        {
            get { return (InfoRecoverySection)Configuration.GetSection("infoSection"); }
        }

        //public static JsonConfigCollection JsonCollection
        //{
        //    get { return InfoConfig.JsonCollection; }
        //}

        public static ModuleConfigCollection ModuleCollection
        {
            get { return InfoConfig.ModuleCollection; }
        }

        //public static IEnumerable<JsonConfigElement> JsonElements
        //{
        //    get
        //    {
        //        foreach (JsonConfigElement json in JsonCollection)
        //        {
        //            if (json != null)
        //                yield return json;
        //        }
        //    }
        //}

        public static JsonConfigElement JsonElement
        {
            get { return InfoConfig.JsonElement; }
        }

        public static IEnumerable<ModuleConfigElement> ModuleElements
        {
            get
            {
                foreach (ModuleConfigElement mod in ModuleCollection)
                {
                    if (mod != null)
                        yield return mod;
                }
            }
        }

    }
}
