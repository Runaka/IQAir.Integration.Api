namespace IQAir.Integration.Api.Options.V2;

public class HttpClientResilienceOptions
{
    public int? RetryCount { get; set; }
    public double? BaseDelaySeconds { get; set; }
}