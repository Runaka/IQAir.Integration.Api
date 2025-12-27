namespace IQAir.Integration.Api.Models.Responses.V2.Enterprise;

public class CityRankingModel
{
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public RankingModel? Ranking { get; set; }
}