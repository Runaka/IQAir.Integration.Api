using IQAir.Integration.Api.Sample.Console.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IQAir.Integration.Api.Sample.Console.Extensions;

public static class ServicesExtensions
{
    public static IServiceCollection AddMeasurementCityOptions(this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.AddOptions<MeasurementCityOptions>().Bind(configuration.GetSection(nameof(MeasurementCityOptions)));
        return services;
    }
    
    public static IServiceCollection AddMeasurementSchedulerOptions(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddOptions<MeasurementSchedulerOptions>().Bind(configuration.GetSection(nameof(MeasurementSchedulerOptions)));
        return services;
    }
}