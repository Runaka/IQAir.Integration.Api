using IQAir.Integration.Api.Models.Responses.V2;

namespace IQAir.Integration.Api.Services.IQAirHttpClient;

public interface IIQAirHttpClient
{
    Task<TResponse?> SendAsync<TRequest, TResponse>(
        string url,
        HttpMethod method,
        TRequest? serviceRequest = null,
        CancellationToken cancellationToken = default) 
        where TResponse : class
        where TRequest : class;
}