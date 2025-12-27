using Coravel.Invocable;
using IQAir.Integration.Api.Models.Requests.V2.Community;
using IQAir.Integration.Api.Models.Responses.V2.Community;
using IQAir.Integration.Api.Models.Responses.V2.Shared;
using IQAir.Integration.Api.Sample.Console.Options;
using IQAir.Integration.Api.Sample.Console.Services;
using IQAir.Integration.Api.Sample.Console.ViewModels;
using IQAir.Integration.Api.Services.V2;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace IQAir.Integration.Api.Sample.Console.BackgroundJobs;

public class UpdateAirPollutionData(IIQAirApiService dataService,
                                    IOptions<MeasurementCityOptions> cityOptions,
                                    ITableDataOutputService tableDataOutputService)  : IInvocable
{
    public async Task Invoke()
    {
        var request = new GetCityDataRequest()
        {
            Country = cityOptions.Value.Country,
            State = cityOptions.Value.State,
            City = cityOptions.Value.City
        };
        var airPollutionInCity = new IQAirResponse<CityDataModel>();
        try
        {
            airPollutionInCity = await dataService.GetCityDataV2(request);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"{JsonConvert.SerializeObject(ex)}");  
        }

        if (airPollutionInCity?.Data?.Current?.Pollution is not null)
        {
            tableDataOutputService.AddRow(new TableRowViewModel()
            {
                AqiUs = airPollutionInCity.Data.Current.Pollution.AqiUs,
                MainPollution = airPollutionInCity.Data.Current.Pollution.MainPollutantUs,
                MeasuredAt = TimeOnly.FromDateTime(airPollutionInCity.Data.Current.Pollution.LastMeasurementAt.LocalDateTime)
            });   
        }
    }
}