using Coravel;
using IQAir.Integration.Api.Extensions;
using IQAir.Integration.Api.Sample.Console.BackgroundJobs;
using IQAir.Integration.Api.Sample.Console.Extensions;
using IQAir.Integration.Api.Sample.Console.Options;
using IQAir.Integration.Api.Sample.Console.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

using var host = Host.CreateDefaultBuilder(args).ConfigureServices(
    (host, services) =>
    {
        services.AddMeasurementCityOptions(host.Configuration);
        services.AddMeasurementSchedulerOptions(host.Configuration);
        services.AddIQAirOpenApiIntegration(host.Configuration);
        services.AddScoped<UpdateAirPollutionData>();
        services.AddSingleton<ITableDataOutputService, TableDataOutputService>();
        services.AddScheduler();
    }).Build();

var measurementTable = host.Services.GetRequiredService<ITableDataOutputService>();
measurementTable.Initialize();

var cityOptions = host.Services.GetRequiredService<IOptions<MeasurementCityOptions>>();
Console.Title = $"IQAir for {cityOptions.Value.City}";

host.Services.AddSchedullerUpdateAirPollutionData();
await host.RunAsync();