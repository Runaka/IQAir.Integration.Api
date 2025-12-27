using IQAir.Integration.Api.Exceptions;
using IQAir.Integration.Api.Models.Requests.V2.Enterprise;
using IQAir.Integration.Api.Models.Requests.V2.Startup;

namespace IQAir.Integration.Api.UnitTests.Tests;

public class EnterpriseApiTests : TestBase
{
    [Fact]
    public async Task Should_Good_Get_Global_City_Ranking_Test()
    {
        var response = await IQAirApiMoqService.GetGlobalCityRankingV2(new GetGlobalCityRankingRequest());
        
        Assert.Equal("success", response.Status);
        Assert.Equal(79,response.Data.Count);
    }
    
    [Theory]
    [InlineData("123", "Country")]
    [InlineData("asc", "Country1")]
    [InlineData("desc", "Country%")]
    public async Task Should_Error_Get_Global_City_Ranking_Test(string? sort, string? countryName)
    {
        var request = new GetGlobalCityRankingRequest()
        {
            Country = countryName,
            Sort = sort
        };
        
        var exception = await Assert.ThrowsAsync<AppValidationRequestException>(
            async () => await IQAirApiMoqService.GetGlobalCityRankingV2(request));
        
        Assert.NotNull(exception.Message);
    }
}
