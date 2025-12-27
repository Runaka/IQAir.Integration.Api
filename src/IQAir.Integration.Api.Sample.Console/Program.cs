using Coravel;
using IQAir.Integration.Api.Extensions;
using IQAir.Integration.Api.Sample.Console.BackgroundJobs;
using IQAir.Integration.Api.Sample.Console.Extensions;
using IQAir.Integration.Api.Sample.Console.Options;
using IQAir.Integration.Api.Sample.Console.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

var builder = Host.CreateApplicationBuilder(args);
var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true)
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddEnvironmentVariables()
    .Build();
builder.Services.AddIQAirOpenApiIntegration(config);
builder.Services.AddScoped<UpdateAirPollutionData>();
builder.Services.AddSingleton<ITableDataOutputService,TableDataOutputService>();
builder.Services.AddMeasurementCityOptions(config);
builder.Services.AddMeasurementSchedulerOptions(config);
builder.Services.AddScheduler();

using var host = builder.Build();

var measurementTable = host.Services.GetRequiredService<ITableDataOutputService>();
measurementTable.Initialize();

var cityOptions = host.Services.GetRequiredService<IOptions<MeasurementCityOptions>>();
Console.Title = $"IQAir for {cityOptions.Value.City}";

host.Services.AddSchedullerUpdateAirPollutionData();
await host.RunAsync();