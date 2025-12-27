using Newtonsoft.Json;

namespace IQAir.Integration.Api.Models.Responses.V2.Startup;

public class PollutionBase
{
    [JsonProperty("conc")]
    public float? Concentrate { get; set; }
    [JsonProperty("aqius")]
    public float AqiUs { get; set; }
    [JsonProperty("aqicn")]
    public float AqiCn { get; set; }
}