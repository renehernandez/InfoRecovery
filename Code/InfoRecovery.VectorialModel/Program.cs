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
                    var create = new VectorialCreateAction() { Action = "create" };
                    var data = new VectorialDataItem();
                    var doc = new DocumentItem();

                    var docs = DocumentReader.Read(modelAction.Path).ToArray();
                    int documentsNumber = docs.Length;
                    var termPerDoc = new Dictionary<string, Dictionary<string, int>>();

                    var info = new ProcessStartInfo(textPath){
                        Arguments = jsonPath,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    foreach (var tuple in docs)
                    {
                        //action.Action = "process";
                        //action.Data = tuple.Item2;
                        //JsonHelper.WriteJson(action, jsonPath);
                        //var proc = Process.Start(info);
                        //proc.WaitForExit();
                        //result = JsonHelper.ReadJson<TextResultAction>(jsonPath);
                        result = new TextResultAction() { Terms = tuple.Item2.Split() };

                        foreach (var term in result.Terms)
                        {
                            if (!termPerDoc.ContainsKey(term))
                                termPerDoc[term] = new Dictionary<string,int>();

                            if(!termPerDoc[term].ContainsKey(tuple.Item1))
                                termPerDoc[term][tuple.Item1] = 1;
                            else
                                termPerDoc[term][tuple.Item1]++;
                        }
                    }

                    create.Data = new List<VectorialDataItem>();
                    foreach (var keyValue in termPerDoc)
                    {
                        data = new VectorialDataItem();
                        data.Key = keyValue.Key;
                        data.Value = new TermItem();
                        data.Value.Idf = Math.Log(documentsNumber * 1.0 / keyValue.Value.Count);
                        data.Value.Documents = new List<DocumentItem>();
                        int max = keyValue.Value.Values.Max();

                        foreach (var item in keyValue.Value)
                        {
                            doc = new DocumentItem() {Document = item.Key, Tf = 0.5 + 0.5 * item.Value / max};
                            data.Value.Documents.Add(doc);
                        }
                        create.Data.Add(data);
                    }

                    JsonHelper.WriteJson(create, jsonPath);
                    info = new ProcessStartInfo(indexPath)
                    {
                        Arguments = jsonPath,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    var process = Process.Start(info);
                    process.WaitForExit();
                }
                else if (modelAction.Query != null)
                {

                }
            }

        }
    }
}
