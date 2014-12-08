using InfoRecovery.Core;
using InfoRecovery.Core.JsonActions;
using System;
using System.Collections.Generic;
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
                var modelAction = JsonHelper.ReadJson<ModelAction>(args[0]);
                string textPath = args[1];
                string indexPath = args[2];

                if (modelAction.Action == "build")
                {
                }
                else if (modelAction.Query != null)
                {

                }
            }

        }
    }
}
