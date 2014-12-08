using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace InfoRecovery.Core
{
    public static class DocumentReader
    {

        public static IEnumerable<Tuple<string, string>> Read(string folderPath)
        {
            var sb = new StringBuilder();

            foreach (var file in Directory.GetFiles(folderPath))
            {
                var info = new FileInfo(file);
                sb.Clear();
   
                switch (info.Extension)
                {
                    case ".pdf":
                        var reader = new PdfReader(file);
                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            sb.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                        }    
                        break;
                    default:
                        using(var sr  = new StreamReader(file)){
                            sb.Append(sr.ReadToEnd());
                        }
                        break;
                }
                
                yield return new Tuple<string, string>(info.Name, sb.ToString());
            }
        }

    }
}
