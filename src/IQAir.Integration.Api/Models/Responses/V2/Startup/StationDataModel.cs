using IQAir.Integration.Api.Models.Responses.V2.Shared;

namespace IQAir.Integration.Api.Models.Responses.V2.Startup;

public class StationDataModel
{
    public string? Name { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public LocationModel? Location { get; set; }
    public StationCurrentCondition? Current { get; set; }
}