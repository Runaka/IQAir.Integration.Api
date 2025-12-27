using IQAir.Integration.Api.Models.Responses.V2.Community;

namespace IQAir.Integration.Api.Models.Responses.V2.Startup;

public class StationCurrentCondition
{
    public StationPollutionModel? Pollution { get; set; }
    public WeatherModel? Weather { get; set; }
}