using CSharpBasicOppgave4_MVC_LINQ.Models;
using CSharpBasicOppgave4_MVC_LINQ.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSharpBasicOppgave4_MVC_LINQ.Controllers;

[ApiController]
[Route("[controller]")]
public class DataController : ControllerBase
{
    private readonly List<DataRow> _data;

    public DataController()
    {
        var reader = new CsvReader();
        _data = reader.Read("Data/dataset.csv");
    }

    [HttpGet("species")]
    public IEnumerable<string> GetSpecies()
    {
        return _data.Select(row => row.Species);
    }

    [HttpGet("large-petals")]
    public IEnumerable<DataRow> GetLargePetals()
    {
        return _data.Where(row => row.PetalLengthCm > 5);
    }

    [HttpGet("ordered")]
    public IEnumerable<DataRow> GetOrderedBySepalLength()
    {
        return _data.OrderBy(row => row.SepalLengthCm);
    }
}