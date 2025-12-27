using System.ComponentModel.DataAnnotations;

namespace IQAir.Integration.Api.Models.Requests.V2.Community;

public class GetNearestCityByGpsRequest
{
    [Required]
    public float? Lat { get; set; }
    
    [Required]
    public float? Lon { get; set; }
}