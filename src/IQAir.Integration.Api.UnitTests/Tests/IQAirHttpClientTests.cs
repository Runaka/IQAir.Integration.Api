using IQAir.Integration.Api.Exceptions;
using IQAir.Integration.Api.Models.Requests.V2.Community;
using IQAir.Integration.Api.Models.Requests.V2.Startup;
using IQAir.Integration.Api.Models.Responses.V2.Community;
using IQAir.Integration.Api.Models.Responses.V2.Shared;
using IQAir.Integration.Api.Services.IQAirHttpClient;
using IQAir.Integration.Api.UnitTests.Mocks;
using Microsoft.Extensions.Logging;
using Moq;

namespace IQAir.Integration.Api.UnitTests.Tests;

public class IQAirHttpClientTests
{
    private IQAirHttpClient _httpClient {get; set;}
    
    public IQAirHttpClientTests()
    {
        var mockFactory = MockHttpFactoryHelper.GetMockHttpClientFactory();       
        var options = MockOptions.GetOptions();
        var mockHttpClientLogger = new Mock<ILogger<IQAirHttpClient>>();
        _httpClient = new IQAirHttpClient(mockFactory, options, mockHttpClientLogger.Object);
    }
    
    [Fact]
    public async Task Should_Exception_When_Url_Empty_Test()
    {
        var exception = await Assert.ThrowsAsync<AppInternalException>(
            async () => await _httpClient.SendAsync<GetCountriesRequest, IQAirResponse<List<CountryModel>>>(
                url:"",
                HttpMethod.Get,
                new GetCountriesRequest(),
                new CancellationToken()
                ));
        
        Assert.NotNull(exception.Message);
    }
    
    [Fact]
    public async Task Should_Exception_When_Forribeden_Answer_Test()
    {
        var exception = await Assert.ThrowsAsync<AppExternalException>(
            async () => await _httpClient.SendAsync<GetCountriesRequest, IQAirResponse<List<CountryModel>>>(
                url:"some_undefined_url_request",
                HttpMethod.Get,
                new GetCountriesRequest(),
                new CancellationToken()
            ));
        
        Assert.NotNull(exception.Message);
    }
}
