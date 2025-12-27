namespace IQAir.Integration.Api.Models.Responses.V2.Community;

public class CurrentCondition
{
    public PollutionModel? Pollution { get; set; }
    public WeatherModel? Weather { get; set; }
}