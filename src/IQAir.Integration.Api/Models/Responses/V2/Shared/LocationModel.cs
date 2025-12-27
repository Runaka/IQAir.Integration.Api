namespace IQAir.Integration.Api.Models.Responses.V2.Shared;

public class LocationModel
{
    public string? Type { get; set; }
    public List<float> Coordinates { get; set; }
}