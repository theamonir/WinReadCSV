using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinReadCSV
{
    public class CustomCSV
    {
        public void Write()
        {
            try
            {
                string filePath = "output.csv";
                int rows = 5;
                int columns = 300;
                var csvContent = new StringBuilder();
                for (int col = 1; col <= columns; col++)
                {
                    csvContent.Append($"Column{col}");
                    if (col < columns) csvContent.Append(",");
                }
                csvContent.AppendLine();
                for (int row = 1; row <= rows; row++)
                {
                    for (int col = 1; col <= columns; col++)
                    {
                        csvContent.Append($"Row{row}_Data{col}");
                        if (col < columns) csvContent.Append(",");
                    }
                    csvContent.AppendLine();
                }
                File.WriteAllText(filePath, csvContent.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Read()
        {
            try
            {
                using (var reader = new StreamReader("output.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var rows = csv.GetRecords<SampleData>();
                    MessageBox.Show(rows.Count().ToString());
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class SampleData
    {
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
    }
}
