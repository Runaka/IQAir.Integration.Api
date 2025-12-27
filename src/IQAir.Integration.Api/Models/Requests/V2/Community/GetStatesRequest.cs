using System.ComponentModel.DataAnnotations;

namespace IQAir.Integration.Api.Models.Requests.V2.Community;

public class GetStatesRequest
{
    [Required]
    [RegularExpression(@"^[a-zA-Z]+$", 
        ErrorMessage = "Country must contain only letters (a-z, A-Z)")]
    public string? Country { get; set; }
}