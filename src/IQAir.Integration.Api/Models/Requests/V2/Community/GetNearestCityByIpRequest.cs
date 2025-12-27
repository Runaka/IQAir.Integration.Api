using System.ComponentModel.DataAnnotations;
using IQAir.Integration.Api.Attributes;

namespace IQAir.Integration.Api.Models.Requests.V2.Community;

public class GetNearestCityByIpRequest
{
    [RegularExpression(
        @"^((25[0-5]|(2[0-4]|1\d|[1-9]|)\d)\.?\b){4}$", 
        ErrorMessage = "Invalid IPv4 address format.")]
    [ForHeader]
    public string? Ip { get; set; }
}