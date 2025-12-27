using IQAir.Integration.Api.Models.Responses.V2.Shared;

namespace IQAir.Integration.Api.Models.Responses.V2.Startup;

public class StationModel
{
    public string Station { get; set; } = string.Empty;
    public LocationModel? Location { get; set; }
}