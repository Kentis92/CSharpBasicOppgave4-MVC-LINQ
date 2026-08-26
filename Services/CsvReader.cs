using CSharpBasicOppgave4_MVC_LINQ.Models;
using System.Globalization;

namespace CSharpBasicOppgave4_MVC_LINQ.Services;

public class CsvReader
{
    public List<DataRow> Read(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        var rows = new List<DataRow>();

        foreach (var line in lines.Skip(1))
        {
            var values = line.Split(',');

            var row = new DataRow
            {
                Id = int.Parse(values[0]),
                SepalLengthCm = double.Parse(values[1], CultureInfo.InvariantCulture),
                SepalWidthCm = double.Parse(values[2], CultureInfo.InvariantCulture),
                PetalLengthCm = double.Parse(values[3], CultureInfo.InvariantCulture),
                PetalWidthCm = double.Parse(values[4], CultureInfo.InvariantCulture),
                Species = values[5]
            };

            rows.Add(row);
        }

        return rows;
    }
}