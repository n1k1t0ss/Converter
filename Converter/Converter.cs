using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace CsvTo1C
{

    public class Propery
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public Propery(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }

    public class Converter 
    {
        public static IEnumerable<T> ParseCsv<T>(StreamReader text, Encoding encoding, string delimiter, int skipFirstN)
        {
            var csvReader = new CsvReader(text);

            csvReader.Configuration.Delimiter = delimiter;
            csvReader.Configuration.Encoding = encoding;
            
            return csvReader.GetRecords<T>().Skip(skipFirstN);
        }

        public delegate List<Propery> HandleProperty(List<Propery> properies);

        public static string FillDocument<T>(IEnumerable<T> classList, string templateBegin, string templateRow, string templateEnd, HandleProperty handleProperty = null) where T : class
        {
            var rows = new StringBuilder();

            // each item in list - one document
            foreach (var @class in classList)
            {
                // get new row template
                var row = new StringBuilder(templateRow);


                var classTemp = @class;

                // get list of all properties for this document
                var docProperties = @class.GetType().GetProperties()
                    .Select(tProperty => new Propery(tProperty.Name, tProperty.GetValue(classTemp, null).ToString())).ToList();

                //docProperties.Select(o => o.Name)
                //docProperties.Select()

                // Invoke delegete, to handle properties 
                if (!ReferenceEquals(handleProperty, null))
                {
                    docProperties = handleProperty(docProperties);
                }

                // each class has list of properties BindingFlags.Public
                foreach (var property in docProperties)
                {
                    // get name and value 
                    var name = property.Name;
                    var val = property.Value;

                    if (rows.Length < 1)
                    {
                        // for the first row replace begin and end
                        rows = new StringBuilder();
                        templateBegin = templateBegin.Replace("{" + name + "}", val);
                        templateEnd = templateEnd.Replace("{" + name + "}", val);
                    }

                    // replace values in document
                    row.Replace("{" + name + "}", val);
                }

                rows.Append(row).Append(System.Environment.NewLine).Append(System.Environment.NewLine);

            }

            return templateBegin + rows + templateEnd;
        }

        //public static string FillDocument<T>(IEnumerable<T> list, string templateBegin, string templateRow, string templateEnd, HandleProperty handleProperty = null) where T : class
        //{
        //    var rows = new StringBuilder();

        //    // each item in list - one document
        //    foreach (var t in list)
        //    {
        //        // get new row template
        //        var row = new StringBuilder(templateRow);

        //        // each class has list of properties BindingFlags.Public
        //        foreach (var tProperty in t.GetType().GetProperties())
        //        {
        //            // get name and value 
        //            var name = tProperty.Name;
        //            var val = tProperty.GetValue(t, null).ToString();

        //            // Invoke delegete, to handle properties 
        //            if (!ReferenceEquals(handleProperty, null))
        //            {
        //                var property = handleProperty.Invoke(new KeyValuePair<string, string>(name, val));
        //                name = property.Key;
        //                val = property.Value;
        //            }

        //            if (rows.Length < 1)
        //            {
        //                // for the first row replace begin and end
        //                rows = new StringBuilder();
        //                templateBegin = templateBegin.Replace("{" + name + "}", val);
        //                templateEnd = templateEnd.Replace("{" + name + "}", val);
        //            }

        //            // replace values in document
        //            row.Replace("{" + name + "}", val);
        //        }

        //        rows.Append(row).Append(System.Environment.NewLine).Append(System.Environment.NewLine);

        //    }

        //    return templateBegin + rows + templateEnd;
        //}

    }
}
