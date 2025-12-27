using IQAir.Integration.Api.Models.Requests.V2.Community;
using IQAir.Integration.Api.Models.Requests.V2.Enterprise;
using IQAir.Integration.Api.Models.Requests.V2.Startup;
using IQAir.Integration.Api.Models.Responses.V2;
using IQAir.Integration.Api.Models.Responses.V2.Community;
using IQAir.Integration.Api.Models.Responses.V2.Enterprise;
using IQAir.Integration.Api.Models.Responses.V2.Shared;
using IQAir.Integration.Api.Models.Responses.V2.Startup;

namespace IQAir.Integration.Api.Services.V2;

public interface IIQAirApiService
{
    Task<IQAirResponse<List<CountryModel>>> GetCountriesV2(
        GetCountriesRequest request,
        CancellationToken cancellationToken = default);
    
    Task<IQAirResponse<List<StateResponseModel>>> GetStatesV2(
        GetStatesRequest request,
        CancellationToken cancellationToken = default);
    
    Task<IQAirResponse<List<CityModel>>> GetCitiesV2(
        GetCitiesRequest request,
        CancellationToken cancellationToken = default);
    
    Task<IQAirResponse<CityDataModel>> GetNearestCityByIpV2(
        GetNearestCityByIpRequest request,
        CancellationToken cancellationToken = default);
    
    Task<IQAirResponse<CityDataModel>> GetNearestCityByGpsV2(
        GetNearestCityByGpsRequest request,
        CancellationToken cancellationToken = default);
    
    Task<IQAirResponse<CityDataModel>> GetCityDataV2(
        GetCityDataRequest request,
        CancellationToken cancellationToken = default);
    
    Task<IQAirResponse<List<StationModel>>> GetCityStationsV2(
        GetCityStationsRequest request,
        CancellationToken cancellationToken = default);
    
    Task<IQAirResponse<StationDataModel>> GetNereastStationDataByIpV2(
        GetNearestStationByIpRequest request,
        CancellationToken cancellationToken = default);
    
    Task<IQAirResponse<StationDataModel>> GetNereastStationDataByGpsV2(
        GetNearestStationByGpsRequest request,
        CancellationToken cancellationToken = default);
    
    Task<IQAirResponse<StationDataModel>> GetStationDataV2(
        GetStationDataRequest request,
        CancellationToken cancellationToken = default);
    
    Task<IQAirResponse<SpecificationCityDataModel>> GetSpecificationCityDataV2(
        GetSpecifiedCityDataRequest request,
        CancellationToken cancellationToken = default);
    
    Task<IQAirResponse<List<CityRankingModel>>> GetGlobalCityRankingV2(
        GetGlobalCityRankingRequest request,
        CancellationToken cancellationToken = default);
}