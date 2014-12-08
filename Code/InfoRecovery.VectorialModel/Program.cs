using InfoRecovery.Core;
using InfoRecovery.Core.JsonActions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace InfoRecovery.VectorialModel
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string jsonPath = args[0];
                string textPath = args[1];
                string indexPath = args[2];

                var modelAction = JsonHelper.ReadJson<ModelAction>(jsonPath);
                
                if (modelAction.Action == "build")
                {
                    var action = new TextAction();
                    TextResultAction result;
                    var docs = DocumentReader.Read(modelAction.Path).ToArray();
                    var create = new VectorialCreateAction();

                    var info = new ProcessStartInfo(textPath){
                        Arguments = jsonPath,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    foreach (var tuple in DocumentReader.Read(modelAction.Path))
                    {
                        action.Action = "process";
                        action.Data = tuple.Item2;
                        JsonHelper.WriteJson(action, jsonPath);
                        var proc = Process.Start(info);
                        proc.WaitForExit();
                        result = JsonHelper.ReadJson<TextResultAction>(jsonPath);
                    }
                }
                else if (modelAction.Query != null)
                {

                }
            }

        }
    }
}
