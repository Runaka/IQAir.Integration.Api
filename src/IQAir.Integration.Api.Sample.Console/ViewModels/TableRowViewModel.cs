namespace IQAir.Integration.Api.Sample.Console.ViewModels;

public class TableRowViewModel
{
    public TimeOnly? MeasuredAt { get; set; }
    public float? AqiUs { get; set; }
    public string? MainPollution { get; set; }
}