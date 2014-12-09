using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoRecovery.Core;
using Newtonsoft.Json;

namespace TestCore
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoRecoveryManager.BuildConfigurations();

            foreach(var text in DocumentReader.Read("C:\\Users\\Aegis\\Desktop\\Test")){
                Console.WriteLine(text);
            }

            //Test t = new Test() { Action = "Test", Age = 1 };
            //JsonHelper.WriteJson(t);
            //Test t1 = JsonHelper.ReadJson<Test>();
            //Console.WriteLine(t1);
        }

    }

    class Test : IJsonSerializable
    {
        public string Action { get; set; }

        //[JsonIgnoreAttribute]
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("Action = {0}, Age = {1}", Action, Age);
        }
        
    }
}
