using System.ComponentModel.DataAnnotations;

namespace IQAir.Integration.Api.Models.Requests.V2.Community;

public class GetStatesRequest
{
    [Required]
    public string? Country { get; set; }
}