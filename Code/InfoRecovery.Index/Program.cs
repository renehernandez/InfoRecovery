using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoRecovery.Index
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DataManager();
            var value1 = @"{
                                idf: 5.4,
                                    {
                                        tf: 5.1,
                                        document: 'path\to\document.pdf'
                                    },
                                    {
                                        tf: 5.1,
                                        document: 'path\to\document.pdf'
                                    }
                           }";
            var value2 = @"{
                                    {
                                        document: 'path\to\document.pdf'
                                    },
                                    {
                                        document: 'path\to\document.pdf'
                                    }
                           }";

            data.Delete("key1");
            data.Add("key1", value1);
            data.Add("key2", value2);
            data.Add("document.pdf", "get");
            Console.WriteLine(data.Get("key1"));
            data.Delete("key1");
            data.Add("key1", "pepe");
            Console.WriteLine(data.Get("key1"));
          
        }

    }
}
