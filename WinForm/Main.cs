using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using CsvTo1C.Contracts;

namespace CsvTo1C.WinForm
{
    public class Main
    {
        public void ConvertCsvTo1C(string filename, int skipFirstNRows, string delimiter, string tranzitBill)
        {
            var text = new StreamReader(filename, Encoding.Default);
            var output = ConvertCsvTo1C(text, skipFirstNRows, delimiter, tranzitBill);
            CreateFile(filename, output);
        }

        public string ConvertCsvTo1C(StreamReader text, int skipFirstNRows, string delimiter, string tranzitBill)
        {
            var list = Converter.ParseCsv<AccountStatementAlfa>(text, Encoding.Default, UnescapeCodes(delimiter), skipFirstNRows);

            return Converter.FillDocument<AccountStatementAlfa>(list,
                                                                      CsvTo1C.Contracts.Templates.AccountStatementAlfa.Begin,
                                                                      CsvTo1C.Contracts.Templates.AccountStatementAlfa.Row,
                                                                      CsvTo1C.Contracts.Templates.AccountStatementAlfa.End,
                                                                      properies =>
                                                                          {
                                                                              switch (properies.Single(o => o.Name == "d_c").Value)
                                                                              {
                                                                                  case "D":
                                                                                      properies.Add(new Propery("DATE_SPIS", properies.Single(o => o.Name == "date_oper").Value));
                                                                                      properies.Add(new Propery("DATE_POST", string.Empty));
                                                                                      break;
                                                                                  case "C":
                                                                                      properies.Add(new Propery("DATE_SPIS", string.Empty));
                                                                                      properies.Add(new Propery("DATE_POST", properies.Single(o => o.Name == "date_oper").Value));
                                                                                      break;
                                                                                  default:
                                                                                      throw new NotSupportedException();
                                                                              }

                                                                              if (!string.IsNullOrEmpty(tranzitBill) && properies.Single(o => o.Name == "pol_acc").Value == tranzitBill)
                                                                              {
                                                                                  foreach (var propery in properies.Where(o => o.Name == "plat_acc"))
                                                                                  { 
                                                                                      propery.Value = string.Empty;
                                                                                  }
                                                                              }


                                                                              return properies;
                                                                          }
                                                                      );

        }




        private void CreateFile(string fileName, string text)
        {
            var newFileName = RenameFileIfExists(fileName, ".txt");
            File.AppendAllText(newFileName, text);
        }

        public static string UnescapeCodes(string src)
        {
            var s = new StringBuilder(src);
            s.Replace("\\f", "\f")
             .Replace("\\r", "\r")
             .Replace("\\n", "\n")
             .Replace("\\t", "\t")
             .Replace("\\v", "\v");
            return s.ToString();
        }

        private string RenameFileIfExists(string fullPath, string newExtension)
        {
            int count = 1;

            string fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
            string path = Path.GetDirectoryName(fullPath);
            string newFullPath = Path.Combine(path, fileNameOnly + newExtension);

            while (File.Exists(newFullPath))
            {
                var tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                newFullPath = Path.Combine(path, tempFileName + newExtension);
            }

            return newFullPath;
        }

    }
}
