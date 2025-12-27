using System.Net;
using Moq;

namespace IQAir.Integration.Api.UnitTests.Mocks;

public static class MockHttpFactoryHelper
{
    public static IHttpClientFactory GetMockHttpClientFactory()
    {
        var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
        
        handlerMock
            .AddDefaultHandlerMock(new SettingMockResponse(MockIQAirServiceResponses.GetErrorForbiddenResponse, HttpStatusCode.Forbidden))
            .AddHandlerMock("countries", new SettingMockResponse(MockIQAirServiceResponses.GetSupportedCountriesGoodResponse, HttpStatusCode.OK))
            .AddHandlerMock("states", new SettingMockResponse(MockIQAirServiceResponses.GetStatesGoodResponse, HttpStatusCode.OK))
            .AddHandlerMock("cities", new SettingMockResponse(MockIQAirServiceResponses.GetCitiesGoodResponse, HttpStatusCode.OK))
            .AddHandlerMock("nearest_city", new SettingMockResponse(MockIQAirServiceResponses.GetNearestCityDateByIpResponse, HttpStatusCode.OK))
            .AddHandlerMock("lat=", new SettingMockResponse(MockIQAirServiceResponses.GetNearestCityDateByGpsResponse, HttpStatusCode.OK))
            .AddHandlerMock("city", new SettingMockResponse(MockIQAirServiceResponses.GetCityDateResponse, HttpStatusCode.OK))
            .AddHandlerMock("stations?", new SettingMockResponse(MockIQAirServiceResponses.GetStationsDateResponse, HttpStatusCode.OK))
            .AddHandlerMock("nearest_station", new SettingMockResponse(MockIQAirServiceResponses.GetNearestStationDateResponse, HttpStatusCode.OK))
            .AddHandlerMock("nearest_station?", new SettingMockResponse(MockIQAirServiceResponses.GetNearestStationDateResponse, HttpStatusCode.OK))
            .AddHandlerMock("station?", new SettingMockResponse(MockIQAirServiceResponses.GetNearestStationDateResponse, HttpStatusCode.OK))
            .AddHandlerMock("city?city", new SettingMockResponse(MockIQAirServiceResponses.GetSpecificationCityDataDateResponse, HttpStatusCode.OK))
            .AddHandlerMock("city_ranking", new SettingMockResponse(MockIQAirServiceResponses.GetGlobalCityRankingResponse, HttpStatusCode.OK))
            ;   
        
        var httpClient = new HttpClient(handlerMock.Object).SetDefaultHttpClientBaseUrl();
        
        var mockFactory = new Mock<IHttpClientFactory>();
        mockFactory
            .Setup(_ => _.CreateClient(It.IsAny<string>()))
            .Returns(httpClient);
        return mockFactory.Object;
    }
}