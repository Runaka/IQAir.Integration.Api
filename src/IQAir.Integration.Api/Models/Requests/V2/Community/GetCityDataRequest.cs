using System.ComponentModel.DataAnnotations;

namespace IQAir.Integration.Api.Models.Requests.V2.Community;

public class GetCityDataRequest
{
    [Required]
    public string? Country { get; set; }
    
    [Required]
    public string? State { get; set; }
    
    [Required]
    public string? City { get; set; }
}