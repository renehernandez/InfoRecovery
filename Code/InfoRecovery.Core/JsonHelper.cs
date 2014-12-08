using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;
using System.IO;

namespace InfoRecovery.Core
{
    public static class JsonHelper
    {

        public static void WriteJson<T>(T obj) where T : IJsonSerializable
        {
            var config = InfoRecoveryManager.InfoConfig;
            using(var sw = new StreamWriter(string.Format("{0}\\{1}.json", config.JsonElement.Path, config.JsonElement.Name)))
            using (var jw = new JsonTextWriter(sw))
            {
                jw.Formatting = Formatting.Indented;
                var serializer = new JsonSerializer();
                serializer.ContractResolver = new LowerCaseContractResolver();
                serializer.Serialize(jw, obj);
            }
        }

        public static T ReadJson<T>() where T : IJsonSerializable
        {
            var config = InfoRecoveryManager.InfoConfig;
            T result;
            using(var sr = new StreamReader(string.Format("{0}\\{1}.json", config.JsonElement.Path, config.JsonElement.Name)))
            using(var jr = new JsonTextReader(sr))
            {
                var serializer = new JsonSerializer();
                result = serializer.Deserialize<T>(jr);
            }

            return result;
        }

    }
}
