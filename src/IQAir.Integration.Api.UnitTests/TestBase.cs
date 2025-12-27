using IQAir.Integration.Api.Services.IQAirHttpClient;
using IQAir.Integration.Api.Services.V2;
using IQAir.Integration.Api.UnitTests.Mocks;
using Microsoft.Extensions.Logging;
using Moq;

namespace IQAir.Integration.Api.UnitTests;

public abstract class TestBase : IDisposable
{
    protected IIQAirApiService IQAirApiMoqService { get; set; }
    
    protected TestBase()
    {
        var mockFactory = MockHttpFactoryHelper.GetMockHttpClientFactory();       
        var options = MockOptions.GetOptions();
        var mockHttpClientLogger = new Mock<ILogger<IQAirHttpClient>>();
        var httpClientIQAir = new IQAirHttpClient(mockFactory, options, mockHttpClientLogger.Object);
        IQAirApiMoqService = new IQAirApiService(httpClientIQAir, options);
    }
    
    public void Dispose()
    {
        
    }
}