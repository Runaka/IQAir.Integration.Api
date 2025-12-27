using IQAir.Integration.Api.Options.V2;
using Microsoft.Extensions.Options;

namespace IQAir.Integration.Api.UnitTests.Mocks;

public static class MockOptions
{   
    public static IOptions<IQAirV2Options> GetOptions()
    {
        var optionsData = new IQAirV2Options()
        {
            ApiKey = "fc79ef9e23e7",/*You api key here*/
            BaseUrl = "https://api.airvisual.com/",
            HttpClientName = "iqair-api-client",
            Resilience = new HttpClientResilienceOptions()
            {
                BaseDelaySeconds = 3,
                RetryCount = 2
            },
            Endpoints = new IQAirV2EndpointOptions()
            {
                GetSupportedCountries = "countries",
                GetSupportedStates = "states",
                GetSupportedCities = "cities",
                GetNearestCityByIp = "nearest_city",
                GetNearestCityByGps = "nearest_city",
                GetCityData = "city",
                //Startup
                GetSupportedStationsInCity = "stations",
                GetNearestStationDataByIp = "nearest_station",
                GetNearestStationDataByGps = "nearest_station",
                GetSpecifiedStationData = "station",
                GetSpecifiedCityData = "city",
                //Enterprice
                GetGlobalCityRanking = "city_ranking"
            }
        };
        var options = Microsoft.Extensions.Options.Options.Create(optionsData);
        return options;
    }
}