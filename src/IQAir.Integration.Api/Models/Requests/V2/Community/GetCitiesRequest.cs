using System.ComponentModel.DataAnnotations;

namespace IQAir.Integration.Api.Models.Requests.V2.Community;

public class GetCitiesRequest
{
    [Required]
    public string? Country { get; set; }
    
    [Required]
    public string? State { get; set; }
}