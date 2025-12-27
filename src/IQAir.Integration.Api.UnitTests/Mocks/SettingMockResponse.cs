using System.Net;

namespace IQAir.Integration.Api.UnitTests.Mocks;

public class SettingMockResponse
{
    public SettingMockResponse(string? response, HttpStatusCode  statusCode)
    {
        Response = response;
        StatusCode = statusCode;
    }
    
    public string? Response { get; set; }
    public HttpStatusCode StatusCode { get; set; }
}