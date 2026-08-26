namespace CSharpBasicOppgave4_MVC_LINQ.Models;

public class DataRow
{
        public int Id { get; set; }
    public double SepalLengthCm { get; set; }
    public double SepalWidthCm { get; set; }
    public double PetalLengthCm { get; set; }
    public double PetalWidthCm { get; set; }
    public string Species { get; set; } = string.Empty;
}