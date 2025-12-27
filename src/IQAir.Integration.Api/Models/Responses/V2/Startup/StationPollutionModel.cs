using IQAir.Integration.Api.Models.Responses.V2.Community;

namespace IQAir.Integration.Api.Models.Responses.V2.Startup;

public class StationPollutionModel : PollutionModel
{
    public PollutionBase? P2 { get; set; }
    public PollutionBase? P1 { get; set; }
    public PollutionBase? O3 { get; set; }
    public PollutionBase? N2 { get; set; }
    public PollutionBase? S2 { get; set; }
    public PollutionBase? Co { get; set; }
}