using Coravel;
using IQAir.Integration.Api.Sample.Console.BackgroundJobs;
using IQAir.Integration.Api.Sample.Console.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace IQAir.Integration.Api.Sample.Console.Extensions;

public static class ServiceProviderExtensions
{
    public static IServiceProvider AddSchedullerUpdateAirPollutionData(this IServiceProvider serviceProvider)
    {
        var measurementSchedulerOptions = serviceProvider.GetService<IOptions<MeasurementSchedulerOptions>>();
        var startTime = int.Parse(measurementSchedulerOptions.Value.StartMinuteInHour.ToString());
        serviceProvider.UseScheduler(scheduler =>
        {
            scheduler.Schedule<UpdateAirPollutionData>()
                .HourlyAt(startTime)
                .RunOnceAtStart();
        });
        return serviceProvider;
    }
}