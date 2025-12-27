using System.ComponentModel.DataAnnotations;

namespace IQAir.Integration.Api.Models.Requests.V2.Startup;

public class GetNearestStationByGpsRequest
{
    [Required]
    public float? Lat { get; set; }
    
    [Required]
    public float? Lon { get; set; }
}