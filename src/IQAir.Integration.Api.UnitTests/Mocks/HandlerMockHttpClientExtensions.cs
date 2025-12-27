using Moq;
using Moq.Protected;

namespace IQAir.Integration.Api.UnitTests.Mocks;

public static class HandlerMockHttpClientExtensions
{
    public static Mock<HttpMessageHandler> AddHandlerMock(this Mock<HttpMessageHandler> handlerMock, string urlPiece, SettingMockResponse settingMockResponse)
    {
        handlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.RequestUri.ToString().Contains(urlPiece)),
                ItExpr.IsAny<CancellationToken>()
            )
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = settingMockResponse.StatusCode,
                Content = new StringContent(settingMockResponse.Response)
            })
            .Verifiable();
        return handlerMock;
    }
    
    public static Mock<HttpMessageHandler> AddHandlerSequencyResponseMock(this Mock<HttpMessageHandler> handlerMock, string urlPiece, IEnumerable<SettingMockResponse> settingMockResponses)
    {
        var sequence = handlerMock.Protected()
            .SetupSequence<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.Is<HttpRequestMessage>(req => req.RequestUri.ToString().Contains(urlPiece)),
                ItExpr.IsAny<CancellationToken>()
            );
        foreach (var settingMockResponse in settingMockResponses)
        {
            sequence.ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = settingMockResponse.StatusCode,
                    Content = new StringContent(settingMockResponse.Response)
                });
        }

        return handlerMock;
    }
    
    public static Mock<HttpMessageHandler> AddDefaultHandlerMock(this Mock<HttpMessageHandler> handlerMock, SettingMockResponse settingMockResponse)
    {
        handlerMock.Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>()
            )
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = settingMockResponse.StatusCode,
                Content = new StringContent(settingMockResponse.Response)
            })
            .Verifiable();
        return handlerMock;
    }

    public static HttpClient SetDefaultHttpClientBaseUrl(this HttpClient httpClient)
    {
        httpClient.BaseAddress = new Uri("http://localhost");
        return httpClient;
    }
}