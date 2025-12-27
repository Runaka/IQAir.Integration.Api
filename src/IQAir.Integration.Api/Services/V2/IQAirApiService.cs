using IQAir.Integration.Api.Models.Requests.V2.Community;
using IQAir.Integration.Api.Models.Requests.V2.Enterprise;
using IQAir.Integration.Api.Models.Requests.V2.Startup;
using IQAir.Integration.Api.Models.Responses.V2.Community;
using IQAir.Integration.Api.Models.Responses.V2.Enterprise;
using IQAir.Integration.Api.Models.Responses.V2.Shared;
using IQAir.Integration.Api.Models.Responses.V2.Startup;
using IQAir.Integration.Api.Options.V2;
using IQAir.Integration.Api.Services.IQAirHttpClient;
using Microsoft.Extensions.Options;

namespace IQAir.Integration.Api.Services.V2;

public class IQAirApiService(IIQAirHttpClient httpClient,
                            IOptions<IQAirV2Options> options) : IIQAirApiService
{
    public async Task<IQAirResponse<List<CountryModel>>> GetCountriesV2(GetCountriesRequest request, CancellationToken cancellationToken = default)
    {
        var serviceResponse = await httpClient
            .SendAsync<GetCountriesRequest, IQAirResponse<List<CountryModel>>>(
                $"{options.Value.Endpoints?.GetSupportedCountries}", HttpMethod.Get,
                request, cancellationToken);
        
        return serviceResponse;
    }

    public async Task<IQAirResponse<List<StateResponseModel>>> GetStatesV2(GetStatesRequest request, CancellationToken cancellationToken = default)
    {
        var serviceResponse = await httpClient
            .SendAsync<GetStatesRequest, IQAirResponse<List<StateResponseModel>>>(
                $"{options.Value.Endpoints?.GetSupportedStates}", HttpMethod.Get,
                request, cancellationToken);
        
        return serviceResponse;
    }
    
    public async Task<IQAirResponse<List<CityModel>>> GetCitiesV2(GetCitiesRequest request, CancellationToken cancellationToken = default)
    {
        var serviceResponse = await httpClient
            .SendAsync<GetCitiesRequest, IQAirResponse<List<CityModel>>>(
                $"{options.Value.Endpoints?.GetSupportedCities}", HttpMethod.Get,
                request, cancellationToken);
        
        return serviceResponse;
    }

    public async Task<IQAirResponse<CityDataModel>> GetNearestCityByIpV2(GetNearestCityByIpRequest request, CancellationToken cancellationToken = default)
    {
        var serviceResponse = await httpClient
            .SendAsync<GetNearestCityByIpRequest, IQAirResponse<CityDataModel>>(
                $"{options.Value.Endpoints?.GetNearestCityByIp}", HttpMethod.Get,
                request, cancellationToken);
        
        return serviceResponse;
    }
    
    public async Task<IQAirResponse<CityDataModel>> GetNearestCityByGpsV2(GetNearestCityByGpsRequest request, CancellationToken cancellationToken = default)
    {
        var serviceResponse = await httpClient
            .SendAsync<GetNearestCityByGpsRequest, IQAirResponse<CityDataModel>>(
                $"{options.Value.Endpoints?.GetNearestCityByGps}", HttpMethod.Get,
                request, cancellationToken);
        
        return serviceResponse;
    }
    
    public async Task<IQAirResponse<CityDataModel>> GetCityDataV2(GetCityDataRequest request, CancellationToken cancellationToken = default)
    {
        var serviceResponse = await httpClient
            .SendAsync<GetCityDataRequest, IQAirResponse<CityDataModel>>(
                $"{options.Value.Endpoints?.GetCityData}", HttpMethod.Get,
                request, cancellationToken);
        
        return serviceResponse;
    }

    public async Task<IQAirResponse<List<StationModel>>> GetCityStationsV2(GetCityStationsRequest request, CancellationToken cancellationToken = default)
    {
        var serviceResponse = await httpClient
            .SendAsync<GetCityStationsRequest, IQAirResponse<List<StationModel>>>(
                $"{options.Value.Endpoints?.GetSupportedStationsInCity}", HttpMethod.Get,
                request, cancellationToken);
        
        return serviceResponse;
    }
    
    public async Task<IQAirResponse<StationDataModel>> GetNereastStationDataByIpV2(GetNearestStationByIpRequest request, CancellationToken cancellationToken = default)
    {
        var serviceResponse = await httpClient
            .SendAsync<GetNearestStationByIpRequest, IQAirResponse<StationDataModel>>(
                $"{options.Value.Endpoints?.GetNearestStationDataByIp}", HttpMethod.Get,
                request, cancellationToken);
        
        return serviceResponse;
    }
    
    public async Task<IQAirResponse<StationDataModel>> GetNereastStationDataByGpsV2(GetNearestStationByGpsRequest request, CancellationToken cancellationToken = default)
    {
        var serviceResponse = await httpClient
            .SendAsync<GetNearestStationByGpsRequest, IQAirResponse<StationDataModel>>(
                $"{options.Value.Endpoints?.GetNearestStationDataByGps}", HttpMethod.Get,
                request, cancellationToken);
        
        return serviceResponse;
    }
    
    public async Task<IQAirResponse<StationDataModel>> GetStationDataV2(GetStationDataRequest request, CancellationToken cancellationToken = default)
    {
        var serviceResponse = await httpClient
            .SendAsync<GetStationDataRequest, IQAirResponse<StationDataModel>>(
                $"{options.Value.Endpoints?.GetSpecifiedStationData}", HttpMethod.Get,
                request, cancellationToken);
        
        return serviceResponse;
    }

    public async Task<IQAirResponse<SpecificationCityDataModel>> GetSpecificationCityDataV2(GetSpecifiedCityDataRequest request, CancellationToken cancellationToken = default)
    {
        var serviceResponse = await httpClient
            .SendAsync<GetSpecifiedCityDataRequest, IQAirResponse<SpecificationCityDataModel>>(
                $"{options.Value.Endpoints?.GetSpecifiedCityData}", HttpMethod.Get,
                request, cancellationToken);
        
        return serviceResponse;
    }
    public async Task<IQAirResponse<List<CityRankingModel>>> GetGlobalCityRankingV2(
        GetGlobalCityRankingRequest request,
        CancellationToken cancellationToken = default)
    {
        var serviceResponse = await httpClient
            .SendAsync<GetGlobalCityRankingRequest, IQAirResponse<List<CityRankingModel>>>(
                $"{options.Value.Endpoints?.GetGlobalCityRanking}", HttpMethod.Get,
                request, cancellationToken);
        
        return serviceResponse;
    }
}