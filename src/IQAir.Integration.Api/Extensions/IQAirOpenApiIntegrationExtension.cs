using IQAir.Integration.Api.Exceptions;
using IQAir.Integration.Api.Options.V2;
using IQAir.Integration.Api.Services.IQAirHttpClient;
using IQAir.Integration.Api.Services.V2;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Http.Resilience;
using Polly;

namespace IQAir.Integration.Api.Extensions;

public static class IQAirOpenApiIntegrationExtension
{
    public static IServiceCollection AddIQAirOpenApiIntegration(this IServiceCollection services,
        IConfiguration configuration)
    {
        var section = configuration.GetSection(nameof(IQAirV2Options));
        services.AddOptions<IQAirV2Options>().Bind(section);
        var iqAirV2Options = section.Get<IQAirV2Options>();
        services.AddHttpClient(iqAirV2Options.HttpClientName, client =>
            {
                client.BaseAddress = new Uri(iqAirV2Options.BaseUrl!);
            })
            .AddResilienceHandler("resilent-strategy", pipelineBuilder =>
            {
                if (iqAirV2Options.Resilience != null)
                {
                    pipelineBuilder
                        .AddRetry(new HttpRetryStrategyOptions
                        {
                            MaxRetryAttempts = iqAirV2Options.Resilience.RetryCount.Value,
                            Delay = TimeSpan.FromSeconds(iqAirV2Options.Resilience.BaseDelaySeconds.Value),
                            BackoffType = DelayBackoffType.Exponential,
                            UseJitter = true,
                            ShouldHandle = new PredicateBuilder<HttpResponseMessage>()
                                .Handle<AppExternalException>()
                                .HandleResult(response => !response.IsSuccessStatusCode)
                        });
                }
            });
        
        services.AddScoped<IIQAirHttpClient, IQAirHttpClient>();
        services.AddScoped<IIQAirApiService, IQAirApiService>();
        
        return services;
    } 
}