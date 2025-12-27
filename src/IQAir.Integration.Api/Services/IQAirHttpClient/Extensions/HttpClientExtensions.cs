using IQAir.Integration.Api.Exceptions;
using IQAir.Integration.Api.Models.Responses.V2.ErrorResponse;
using Microsoft.Extensions.Logging;

namespace IQAir.Integration.Api.Services.IQAirHttpClient.Extensions;

public static  class HttpClientExtensions
{
    public static async Task ValidateResponseStatusCode(
        this HttpResponseMessage responseMessage, 
        ILogger logger,
        
        CancellationToken cancellationToken = default)
    {
        if (responseMessage.IsSuccessStatusCode) 
            return;

        var content = await responseMessage.Content.ReadAsStringAsync(cancellationToken);
        logger.LogError("HttpClient api error response {Content}", content);
        
        throw new AppExternalException(
            message: "Error occured while validating the response" +
        $"Status code: {responseMessage.StatusCode}," +
         $" Body: {content}");
    }
}