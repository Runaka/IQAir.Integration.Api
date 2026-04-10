using System.ComponentModel.DataAnnotations;

namespace IQAir.Integration.Api.Models.Requests.V2.Startup;

public class GetStationDataRequest
{
    [Required]
    public string? Name { get; set; }
    
    [Required]
    public string? Country { get; set; }
    
    [Required]
    public string? State { get; set; }
    
    [Required]
    public string? City { get; set; }
}