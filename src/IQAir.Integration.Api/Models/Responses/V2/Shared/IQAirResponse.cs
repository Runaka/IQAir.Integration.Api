
namespace IQAir.Integration.Api.Models.Responses.V2.Shared;

public class IQAirResponse<TResponse> where TResponse: class
{
    public string? Status { get; set; }
    
    public TResponse? Data { get; set; }
}