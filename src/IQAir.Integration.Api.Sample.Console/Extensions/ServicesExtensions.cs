using IQAir.Integration.Api.Sample.Console.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IQAir.Integration.Api.Sample.Console.Extensions;

public static class ServicesExtensions
{
    public static IServiceCollection AddMeasurementCityOptions(this IServiceCollection services, IConfiguration config)
    {
        services.Configure<MeasurementCityOptions>(config.GetSection(nameof(MeasurementCityOptions)));
        var measurementCityOptions = new MeasurementCityOptions();
        config.GetSection(nameof(MeasurementCityOptions)).Bind(measurementCityOptions);
        return services;
    }
    
    public static IServiceCollection AddMeasurementSchedulerOptions(this IServiceCollection services, IConfiguration config)
    {
        services.Configure<MeasurementSchedulerOptions>(config.GetSection(nameof(MeasurementSchedulerOptions)));
        var measurementSchedulerOptions = new MeasurementSchedulerOptions();
        config.GetSection(nameof(MeasurementSchedulerOptions)).Bind(measurementSchedulerOptions);
        return services;
    }
}