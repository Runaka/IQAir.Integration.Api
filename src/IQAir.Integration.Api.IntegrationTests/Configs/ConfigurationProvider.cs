namespace IQAir.Integration.Api.IntegrationTests.Configs;

public static class TestConfigurationProvider
{
    public static class IQAirV2Options
    {
        public static KeyValuePair<string, string>[] GetConfiguration()
        {
            return
            [
                new KeyValuePair<string, string>("IQAirV2Options:ApiKey", "e63b1173-f571-496e-8f8d-7a861c927752"),
                new KeyValuePair<string, string>("IQAirV2Options:BaseUrl", "https://api.airvisual.com/v2/"),
                new KeyValuePair<string, string>("IQAirV2Options:HttpClientName", "iqair-api-client"),
                new KeyValuePair<string, string>("IQAirV2Options:Resilience:BaseDelaySeconds", "3"),
                new KeyValuePair<string, string>("IQAirV2Options:Resilience:RetryCount", "2"),
                //Community
                new KeyValuePair<string, string>("IQAirV2Options:Endpoints:GetSupportedCountries", "countries"),
                new KeyValuePair<string, string>("IQAirV2Options:Endpoints:GetSupportedStates", "states"),
                new KeyValuePair<string, string>("IQAirV2Options:Endpoints:GetSupportedCities", "cities"),
                new KeyValuePair<string, string>("IQAirV2Options:Endpoints:GetNearestCityByIp", "nearest_city"),
                new KeyValuePair<string, string>("IQAirV2Options:Endpoints:GetNearestCityByGps", "nearest_city"),
                new KeyValuePair<string, string>("IQAirV2Options:Endpoints:GetCityData", "city"),
                //Startup
                new KeyValuePair<string, string>("IQAirV2Options:Endpoints:GetSupportedStationsInCity", "stations"),
                new KeyValuePair<string, string>("IQAirV2Options:Endpoints:GetNearestStationDataByIp", "nearest_station"),
                new KeyValuePair<string, string>("IQAirV2Options:Endpoints:GetNearestStationDataByGps", "nearest_station"),
                new KeyValuePair<string, string>("IQAirV2Options:Endpoints:GetSpecifiedStationData", "station"),
                new KeyValuePair<string, string>("IQAirV2Options:Endpoints:GetSpecifiedCityData", "city"),
                //Enterprise
                new KeyValuePair<string, string>("IQAirV2Options:Endpoints:GetGlobalCityRanking", "city_ranking"),
                
            ];
        }
    }
}