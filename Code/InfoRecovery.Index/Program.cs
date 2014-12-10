using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfoRecovery.Core;
using InfoRecovery.Core.JsonActions;

namespace InfoRecovery.Index
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                var data = new DataManager();

                string jsonPath = args[0];
                var indexAction = JsonHelper.ReadJson<IndexAction>(jsonPath);
                var indexResultAction = new IndexResultAction { Success = "false" };

                switch (indexAction.Action)
                {
                    case "create":
                        foreach (var md in indexAction.Data)
                            data.Add(md.Key, "TODO:Vlue");
                        indexResultAction.Success = "true";
                        break;
                    case "insert":
                        break;
                    case "get":
                        var sValue =  data.Get(indexAction.Key);
                        indexResultAction.Success = "true";
                        break;
                    case "update":
                        break;
                    case "delete":
                        break;

                }
                JsonHelper.WriteJson<IndexResultAction>(indexResultAction, jsonPath);
            }
          
        }

    }
}
