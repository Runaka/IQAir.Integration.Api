namespace IQAir.Integration.Api.Options.V2;

public class IQAirV2Options
{
    public string? BaseUrl { get; set; }
    public string? ApiKey { get; set; }
    public string? HttpClientName { get; set; }
    public IQAirV2EndpointOptions? Endpoints { get; set; }
    public HttpClientResilienceOptions? Resilience { get; set; }
}