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

        public static void WriteJson<T>(T obj, string path) where T : IJsonSerializable
        {
            using(var sw = new StreamWriter(path))
            using (var jw = new JsonTextWriter(sw))
            {
                jw.Formatting = Formatting.Indented;
                var serializer = new JsonSerializer();
                serializer.ContractResolver = new LowerCaseContractResolver();
                serializer.Serialize(jw, obj);
            }
        }

        public static T ReadJson<T>(string path) where T : IJsonSerializable
        {
            T result;
            using(var sr = new StreamReader(path))
            using(var jr = new JsonTextReader(sr))
            {
                var serializer = new JsonSerializer();
                result = serializer.Deserialize<T>(jr);
            }

            return result;
        }

    }
}
