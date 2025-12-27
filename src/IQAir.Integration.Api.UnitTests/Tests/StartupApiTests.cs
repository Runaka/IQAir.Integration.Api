using IQAir.Integration.Api.Exceptions;
using IQAir.Integration.Api.Models.Requests.V2.Startup;

namespace IQAir.Integration.Api.UnitTests.Tests;

public class StartupApiTests : TestBase
{
    [Fact]
    public async Task Should_Good_Get_City_Stations_Test()
    {
        var response = await IQAirApiMoqService.GetCityStationsV2(new GetCityStationsRequest(){
            Country = "India",
            State = "Delhi",
            City = "Delhi"
    });

        Assert.Equal("success", response.Status);
        Assert.Equal(2,response.Data.Count);
    }
    
    
    [Theory]
    [InlineData("")]
    [InlineData("qw34")]
    [InlineData("fiirt@")]
    public async Task Should_Exception_Get_City_Stations_Test(string? someName)
    {
        var request = new GetCityStationsRequest(){
            Country = someName,
            State = someName,
            City = someName
        };
        
        var exception = await Assert.ThrowsAsync<AppValidationRequestException>(
            async () => await IQAirApiMoqService.GetCityStationsV2(request));
        
        Assert.NotNull(exception.Message);
    }
    
    [Fact]
    public async Task Should_Good_Get_Station_Data_By_Ip_Test()
    {
        var response = await IQAirApiMoqService.GetNereastStationDataByIpV2(new GetNearestStationByIpRequest(){
            Ip = "157.49.12.214"
        });
        
        Assert.Equal("success", response.Status);
        Assert.NotNull(response.Data);
    }
    
    [Theory]
    [InlineData("abc")]
    [InlineData("157.49.12")]
    [InlineData(" ")]
    public async Task Should_Error_Get_Station_Data_By_Ip_Test(string ipAddress)
    {
        var request = new GetNearestStationByIpRequest()
        {
            Ip = ipAddress
        };
        
        var exception = await Assert.ThrowsAsync<AppValidationRequestException>(
            async () => await IQAirApiMoqService.GetNereastStationDataByIpV2(request));
        
        Assert.NotNull(exception.Message);
    }
    
    [Fact]
    public async Task Should_Good_Get_Station_Data_By_Gps_Test()
    {
        var response = await IQAirApiMoqService.GetNereastStationDataByGpsV2(new GetNearestStationByGpsRequest(){
            Lat = 1,
            Lon = 1,
        });
        
        Assert.Equal("success", response.Status);
        Assert.NotNull(response.Data);
    }

    [Theory]
    [InlineData(null,null)]
    [InlineData(null,1f)]
    [InlineData(1f,null)]
    public async Task Should_Exeption_Get_Station_Data_By_Gps_Test(float? latitude, float? longitude)
    {
        var request = new GetNearestStationByGpsRequest()
        {
            Lat = latitude,
            Lon = longitude
        };
        
        var exception = await Assert.ThrowsAsync<AppValidationRequestException>(
            async () => await IQAirApiMoqService.GetNereastStationDataByGpsV2(request));
        
        Assert.NotNull(exception.Message);
    }
    
    
    [Fact]
    public async Task Should_Good_Get_Station_Data_Test()
    {
        var response = await IQAirApiMoqService.GetStationDataV2(new GetStationDataRequest(){
            Name = "TestStation",
            City = "TestCity",
            Country = "TestCountry",
            State = "TestState"
        });
        
        Assert.Equal("success", response.Status);
        Assert.NotNull(response.Data);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("123")]
    [InlineData("DRRF123")]
    [InlineData("DRRF%")]
    public async Task Should_Error_Get_Station_Data_Test(string? someString)
    {
        var request = new GetStationDataRequest()
        {
            Name = someString,
            Country = someString,
            State = someString,
            City = someString
        };
        
        var exception = await Assert.ThrowsAsync<AppValidationRequestException>(
            async () => await IQAirApiMoqService.GetStationDataV2(request));
        
        Assert.NotNull(exception.Message);
    }
    
    [Fact]
    public async Task Should_Good_Get_Specification_City_Data_Test()
    {
        var response = await IQAirApiMoqService.GetSpecificationCityDataV2(new GetSpecifiedCityDataRequest(){
            City = "TestCity",
            Country = "TestCountry",
            State = "TestState"
        });
        
        Assert.Equal("success", response.Status);
        Assert.NotNull(response.Data);
    }
    
    
    [Theory]
    [InlineData(null)]
    [InlineData("123")]
    [InlineData("DRRF123")]
    [InlineData("DRRF%")]
    public async Task Should_Error_Get_Specification_City_Data_Test(string? someString)
    {
        var request = new GetSpecifiedCityDataRequest()
        {
            Country = someString,
            State = someString,
            City = someString
        };
        
        var exception = await Assert.ThrowsAsync<AppValidationRequestException>(
            async () => await IQAirApiMoqService.GetSpecificationCityDataV2(request));
        
        Assert.NotNull(exception.Message);
    }
}
