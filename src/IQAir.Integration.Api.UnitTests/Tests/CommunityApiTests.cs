using IQAir.Integration.Api.Exceptions;
using IQAir.Integration.Api.Models.Requests.V2.Community;

namespace IQAir.Integration.Api.UnitTests.Tests;

public class CommunityApiTests : TestBase
{
    [Fact]
    public async Task Should_Good_Get_Supported_Cities_Test()
    {
        var response = await IQAirApiMoqService.GetCountriesV2(new GetCountriesRequest());
        
        Assert.Equal("success", response.Status);
        Assert.Equal(15, response.Data.Count);
    }
    
    [Fact]
    public async Task Should_Good_Get_Supported_States_In_Country_Test()
    {
        var response = await IQAirApiMoqService.GetStatesV2(new GetStatesRequest()
        {
            Country = "India" 
        });
        
        Assert.Equal("success", response.Status);
        Assert.Equal(6, response.Data.Count);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("123")]
    [InlineData("DRRF123")]
    [InlineData("DRRF%")]
    public async Task Should_Exception_Get_Supported_States_In_Country_Test(string? countryName)
    {
        var request = new GetStatesRequest()
        {
            Country = countryName 
        };
        
        var exception = await Assert.ThrowsAsync<AppValidationRequestException>(
            async () => await IQAirApiMoqService.GetStatesV2(request));
        
        Assert.NotNull(exception.Message);
    }
    
    [Fact]
    public async Task Should_Good_Get_Supported_Cities_In_State_Test()
    {
        var response = await IQAirApiMoqService.GetCitiesV2(new GetCitiesRequest()
        {
            Country = "India", 
            State = "Delhi" 
        });
        
        Assert.Equal("success", response.Status);
        Assert.Equal(5, response.Data.Count);
    }
    
    [Fact]
    public async Task Should_Good_Get_Nearest_City_By_Ip_Data_Test()
    {
        var response = await IQAirApiMoqService.GetNearestCityByIpV2(new GetNearestCityByIpRequest()
        {
            Ip = "157.49.12.214"
        });
        
        Assert.Equal("success", response.Status);
        Assert.NotNull(response.Data);
    }
    
    [Theory]
    [InlineData("abc")]
    [InlineData("157.49.12")]
    [InlineData(" ")]
    public async Task Should_Error_Get_Nearest_City_By_Incorrect_Ip_Data_Test(string ipAddress)
    {
        var request = new GetNearestCityByIpRequest()
        {
            Ip = ipAddress
        };
        
        var exception = await Assert.ThrowsAsync<AppValidationRequestException>(
            async () => await IQAirApiMoqService.GetNearestCityByIpV2(request));
        
        Assert.NotNull(exception.Message);
    }
    
    [Theory]
    [InlineData(28.7041f,77.1025f)]
    public async Task Should_Good_Get_Nearest_City_By_Gps_Data_Test(float latitude, float longitude)
    {
        var response = await IQAirApiMoqService.GetNearestCityByGpsV2(new GetNearestCityByGpsRequest()
        {
            Lat = latitude,
            Lon = longitude
        });
        
        Assert.Equal("success", response.Status);
        Assert.NotNull(response.Data);
    }
    
    [Theory]
    [InlineData(null,null)]
    public async Task Should_Exception_Get_Nearest_City_By_Gps_Data_Test(float? latitude, float? longitude)
    {
        var request = new GetNearestCityByGpsRequest()
        {
            Lat = latitude,
            Lon = longitude
        };
        
        var exception = await Assert.ThrowsAsync<AppValidationRequestException>(
            async () => await IQAirApiMoqService.GetNearestCityByGpsV2(request));
        
        Assert.NotNull(exception.Message);
    }
    
    [Fact]
    public async Task Should_Good_Get_City_Data_Test()
    {
        var response = await IQAirApiMoqService.GetCityDataV2(new GetCityDataRequest()
        {
            Country = "India",
            State = "Delhi",
            City = "Delhi"
        });
        
        Assert.Equal("success", response.Status);
        Assert.NotNull(response.Data);
    }
    
}