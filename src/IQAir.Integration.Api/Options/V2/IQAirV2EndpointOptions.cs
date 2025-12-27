namespace IQAir.Integration.Api.Options.V2;

public class IQAirV2EndpointOptions
{
    //Community
    public string? GetSupportedCountries { get; set; }
    public string? GetSupportedStates { get; set; }
    public string? GetSupportedCities { get; set; }
    public string? GetNearestCityByIp { get; set; }
    public string? GetNearestCityByGps { get; set; }
    public string? GetCityData { get; set; }
    //Startup
    public string? GetSupportedStationsInCity { get; set; }
    public string? GetNearestStationDataByIp { get; set; }
    public string? GetNearestStationDataByGps { get; set; }
    public string? GetSpecifiedStationData { get; set; }
    public string? GetSpecifiedCityData { get; set; }
    //Enterprice
    public string? GetGlobalCityRanking { get; set; }
}