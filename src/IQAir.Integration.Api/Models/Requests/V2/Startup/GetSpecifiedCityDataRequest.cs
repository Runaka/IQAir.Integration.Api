using System.ComponentModel.DataAnnotations;

namespace IQAir.Integration.Api.Models.Requests.V2.Startup;

public class GetSpecifiedCityDataRequest
{
    [Required]
    public string? City { get; set; }
    
    [Required]
    public string? State { get; set; }
    
    [Required]
    public string? Country { get; set; }
    
}