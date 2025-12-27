using Newtonsoft.Json;

namespace IQAir.Integration.Api.Models.Responses.V2.Enterprise;

public class RankingModel
{
    [JsonProperty("current_aqi")]
    public float? CurrentAqi { get; set; }
    
    [JsonProperty("current_aqi_cn")]
    public float? CurrentAqiCn { get; set; }
}