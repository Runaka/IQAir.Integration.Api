using IQAir.Integration.Api.Models.Responses.V2.Shared;

namespace IQAir.Integration.Api.Models.Responses.V2.Community;

public class CityDataModel
{
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public LocationModel? Location { get; set; }
    public CurrentCondition? Current { get; set; }
}
