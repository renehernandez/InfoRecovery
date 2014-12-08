using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace InfoRecovery.Core
{
    public static class DocumentReader
    {

        public static IEnumerable<string> Read(string folderPath)
        {
            foreach (var file in Directory.GetFiles(folderPath))
            {
                var sr = new StreamReader(file);
                yield return sr.ReadToEnd();
            }
        }

    }
}
