using System.ComponentModel.DataAnnotations;

namespace IQAir.Integration.Api.Models.Requests.V2.Community;

public class GetCityDataRequest
{
    [Required]
    [RegularExpression(@"^[a-zA-Z]+$", 
        ErrorMessage = "Country must contain only letters (a-z, A-Z)")]
    public string? Country { get; set; }
    
    [Required]
    [RegularExpression(@"^[a-zA-Z]+$", 
        ErrorMessage = "State must contain only letters (a-z, A-Z)")]
    public string? State { get; set; }
    
    [Required]
    [RegularExpression(@"^[a-zA-Z]+$", 
        ErrorMessage = "City must contain only letters (a-z, A-Z)")]
    public string? City { get; set; }
}