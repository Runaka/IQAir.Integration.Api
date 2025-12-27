using Newtonsoft.Json;

namespace IQAir.Integration.Api.Models.Responses.V2.Community;

public class PollutionModel
{
    [JsonProperty("ts")]
    public DateTimeOffset LastMeasurementAt { get; set; }

    [JsonProperty("aqius")]
    public int AqiUs { get; set; }

    [JsonProperty("mainus")]
    public string MainPollutantUs { get; set; } = string.Empty;

    [JsonProperty("aqicn")]
    public int AqiCn { get; set; }

    [JsonProperty("maincn")]
    public string MainPollutantCn { get; set; } = string.Empty;

    // Helper to get a human-readable name of the main pollutant
    [JsonIgnore]
    public string MainPollutantFriendlyName => MainPollutantUs switch
    {
        "p2" => "Fine Particulate Matter ($< 2.5\\mu m$) P2.5",
        "p1" => "Coarse Particulate Matter ($< 10\\mu m$) P10",
        "o3" => "Ground-level Ozone O3",
        "n2" => "Nitrogen Dioxide NO2",  
        "s2" => "Sulfur dioxide SO2",  
        "co" => "Carbon monoxide CO"
    };
}