using IQAir.Integration.Api.Extensions;
using IQAir.Integration.Api.IntegrationTests.Configs;
using IQAir.Integration.Api.Models.Requests.V2.Community;
using IQAir.Integration.Api.Models.Requests.V2.Startup;
using IQAir.Integration.Api.Services.V2;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace IQAir.Integration.Api.IntegrationTests.Tests;
    
public sealed class StartupApiTest
{
    private IIQAirApiService _iqairApiService;
    private IServiceProvider _serviceProvider;
    
    [SetUp]
    public void Setup()
    {
        var configuration = new ConfigurationBuilder()
            .AddTestConfigurations(
                TestConfigurationProvider.IQAirV2Options.GetConfiguration()
            )
            .Build();

        var services = new ServiceCollection();
        using var loggerFactory = LoggerFactory.Create(logger => logger.SetMinimumLevel(LogLevel.Debug));
        services.AddHttpContextAccessor();

        services.AddIQAirOpenApiIntegration(configuration);
        _serviceProvider = services.BuildServiceProvider();
        _iqairApiService = _serviceProvider.GetRequiredService<IIQAirApiService>();
    }

    [Test]
    public async Task GetStationsTest()
    {
        var responses = await _iqairApiService!.GetCityStationsV2(new GetCityStationsRequest()
        {
            Country = "India",
            State = "Delhi",
            City = "Delhi"
        });

        Assert.That(responses, Is.Not.Null.Or.Empty);
        Assert.That(responses.Status, Is.EqualTo("success"));
        Assert.That(responses.Data, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.Count, Is.GreaterThan(0));
    }
    
    
    [Test]
    public async Task GetNerestStationByIpTest()
    {
        var responses = await _iqairApiService!.GetNereastStationDataByIpV2(new GetNearestStationByIpRequest()
        {
            Ip = "157.49.12.214"
        });

        Assert.That(responses, Is.Not.Null.Or.Empty);
        Assert.That(responses.Status, Is.EqualTo("success"));
        Assert.That(responses.Data, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.Country, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.State, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.City, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.Current, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.Location, Is.Not.Null.Or.Empty);
    }
    
    [Test]
    public async Task GetNerestStationByGpsTest()
    {
        var responses = await _iqairApiService!.GetNereastStationDataByGpsV2(new GetNearestStationByGpsRequest()
        {
            Lat = 34.052235f,
            Lon = -118.243683f
        });

        Assert.That(responses, Is.Not.Null.Or.Empty);
        Assert.That(responses.Status, Is.EqualTo("success"));
        Assert.That(responses.Data, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.Country, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.State, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.City, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.Current, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.Location, Is.Not.Null.Or.Empty);
    }
    
    [Test]
    public async Task GetStationDataTest()
    {
        var responses = await _iqairApiService!.GetStationDataV2(new GetStationDataRequest()
        {
            Country = "India",
            State = "Delhi",
            City = "Delhi",
            Name = "Najafgarh"
        });

        Assert.That(responses, Is.Not.Null.Or.Empty);
        Assert.That(responses.Status, Is.EqualTo("success"));
        Assert.That(responses.Data, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.Country, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.State, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.City, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.Current, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.Location, Is.Not.Null.Or.Empty);
    }

    
    [Test]
    public async Task GetSpecifiedCityDataTest()
    {
        var responses = await _iqairApiService!.GetSpecificationCityDataV2(new GetSpecifiedCityDataRequest()
        {
            Country = "India",
            State = "Delhi",
            City = "Delhi"
        });

        Assert.That(responses, Is.Not.Null.Or.Empty);
        Assert.That(responses.Status, Is.EqualTo("success"));
        Assert.That(responses.Data, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.Country, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.State, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.City, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.Current, Is.Not.Null.Or.Empty);
        Assert.That(responses.Data.Location, Is.Not.Null.Or.Empty);
    }

    

    [TearDown]
    public void Dispose()
    {
        if (_serviceProvider is IDisposable disposable)
            disposable.Dispose();
    }
}