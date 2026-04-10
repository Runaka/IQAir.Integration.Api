using System.ComponentModel.DataAnnotations;

namespace IQAir.Integration.Api.Models.Requests.V2.Enterprise;

public class GetGlobalCityRankingRequest
{
    [RegularExpression(@"^(asc|desc)$", ErrorMessage = "Sort order must be 'asc' or 'desc'.")]
    public string? Sort { get; set; }

    
    public string? Country { get; set; }
}