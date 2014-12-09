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
                TextAction action;
                TextResultAction result;
                ModelSendAction create;

                var info = new ProcessStartInfo(textPath)
                {
                    Arguments = jsonPath,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                
                if (modelAction.Action == "build")
                {              
                    ModelData data;
                    DocumentData doc;
                    create = new ModelSendAction() { Action = "create" };
                    
                    var docs = DocumentReader.Read(modelAction.Path).ToArray();
                    int documentsNumber = docs.Length;
                    var termPerDoc = new Dictionary<string, Dictionary<string, int>>();
                    var normDoc = new Dictionary<string, double>();

                    foreach (var tuple in docs)
                    {
                        action.Action = "process";
                        action.Data = tuple.Item2;
                        JsonHelper.WriteJson(action, jsonPath);
                        var proc = Process.Start(info);
                        proc.WaitForExit();
                        result = JsonHelper.ReadJson<TextResultAction>(jsonPath);
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

                    foreach (var keyValue in termPerDoc)
                    {
                        double idf = Math.Log(documentsNumber * 1.0 / keyValue.Value.Count);
                        foreach (var item in keyValue.Value)
                        {
                            if (!normDoc.ContainsKey(item.Key))
                                normDoc[item.Key] = 0;

                            int max = keyValue.Value.Values.Max();
                            double tf = 0.5 + 0.5 * item.Value / max;
                            normDoc[item.Key] += (idf * tf) * (idf * tf);
                        }
                    }

                    create.Data = new List<ModelData>();
                    foreach (var keyValue in termPerDoc)
                    {
                        data = new ModelData();
                        data.Key = keyValue.Key;
                        data.Value = new ValueData();
                        data.Value.Idf = Math.Log(documentsNumber * 1.0 / keyValue.Value.Count);
                        data.Value.Documents = new List<DocumentData>();
                        int max = keyValue.Value.Values.Max();

                        foreach (var item in keyValue.Value)
                        {
                            double norm = Math.Sqrt(normDoc[item.Key]);
                            doc = new DocumentData() {Document = item.Key, Tf = (0.5 + 0.5 * item.Value / max) / norm};
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
                    action.Action = "process";
                    action.Data = modelAction.Query;
                    JsonHelper.WriteJson(action, jsonPath);
                    var proc = Process.Start(info);
                    proc.WaitForExit();
                    result = JsonHelper.ReadJson<TextResultAction>(jsonPath);
                }
            }

        }
    }
}
