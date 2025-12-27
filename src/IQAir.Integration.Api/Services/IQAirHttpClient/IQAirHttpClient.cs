using System.Collections;
using System.Globalization;
using System.Net;
using IQAir.Integration.Api.Attributes;
using IQAir.Integration.Api.Exceptions;
using IQAir.Integration.Api.Helpers;
using IQAir.Integration.Api.Options.V2;
using IQAir.Integration.Api.Services.IQAirHttpClient.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace IQAir.Integration.Api.Services.IQAirHttpClient;

public class IQAirHttpClient : IIQAirHttpClient
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IQAirV2Options _options;
    private readonly ILogger<IQAirHttpClient> _logger;
    private readonly HttpClient _client;
    
    public IQAirHttpClient(IHttpClientFactory httpClientFactory, 
                            IOptions<IQAirV2Options> options,
                            ILogger<IQAirHttpClient> logger)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
        _client = _httpClientFactory.CreateClient(_options.HttpClientName);
        _logger = logger;
    }
    
    protected static readonly JsonSerializerSettings SerializerSettings = new()
    {
        ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() },
        //Formatting = Formatting.Indented,
        DateFormatString = "yyyy-MM-ddTHH:mm:ss.fffK" //2025-12-21T12:00:00.000Z
    };
    
     public virtual async Task<TResponse?> SendAsync<TRequest, TResponse>(
        string url,
        HttpMethod method,
        TRequest? serviceRequest = null,
        CancellationToken cancellationToken = default)
         where TResponse : class
         where TRequest : class
    {
        if (string.IsNullOrWhiteSpace(url))
            throw new AppInternalException( $"URL cannot be null or whitespace. for request, {nameof(TRequest)}" );

        ValidationHelper.IsNotValidThrowException(serviceRequest);
        
        var queryString = SerializeQueryParameters(serviceRequest);
        queryString = AddApiKeyToQueryParameters(_options, queryString);
        
        if (!string.IsNullOrWhiteSpace(queryString))
        {
            var separator = url.Contains("?") ? "&" : "?";
            url = $"{url}{separator}{queryString}";
        }
        
        using var request = new HttpRequestMessage(method, url);
        AddRequestHeaders(request, serviceRequest);
        
        using var response = await _client.SendAsync(request, cancellationToken);
        await response.ValidateResponseStatusCode(_logger, cancellationToken);

        if (response.StatusCode == HttpStatusCode.NoContent)
        {
            return null;//todo rewrite
        }

        var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);
        var responseModel = DeserializeResponse<TResponse>(responseContent);

        return responseModel;
    }

    protected virtual void AddRequestHeaders<TRequest>(HttpRequestMessage request, TRequest payload)
    {
        var property = typeof(TRequest).GetProperties()
            .FirstOrDefault(p => Attribute.IsDefined(p, typeof(ForHeaderAttribute)));
        if (property is not null)
        {
            var value = property.GetValue(payload);
            if (value is not null)
            {
                request.Headers.Add("x-forwarded-for",  value.ToString());
            }
        }
    }
     
    protected virtual TResponse? DeserializeResponse<TResponse>(string responseContent)
    {
        return JsonConvert.DeserializeObject<TResponse>(responseContent, SerializerSettings);
    } 
     
    protected virtual string SerializeQueryParameters<TRequest>(TRequest payload)
    {
        var queryParams = new List<string>();
        
        foreach (var prop in typeof(TRequest).GetProperties().Where(p => !Attribute.IsDefined(p, typeof(ForHeaderAttribute))))
        {
            var value = prop.GetValue(payload);
            if (value != null)
            {
                var propName = string.IsNullOrEmpty(prop.Name)
                    ? prop.Name
                    : string.Concat(prop.Name[0].ToString().ToLowerInvariant(),
                        prop.Name.AsSpan(1)); // camelCase to lower conversion

                if (value is IEnumerable enumerable && value is not string)
                {
                    foreach (var item in enumerable)
                    {
                        queryParams.Add($"{Uri.EscapeDataString(propName)}={Uri.EscapeDataString(Convert.ToString(item, CultureInfo.InvariantCulture))}");
                    }
                }
                else
                {
                    queryParams.Add($"{Uri.EscapeDataString(propName)}={Uri.EscapeDataString(Convert.ToString(value, CultureInfo.InvariantCulture))}");
                }
            }
        }

        return string.Join("&", queryParams);
    }

    protected virtual string AddApiKeyToQueryParameters(IQAirV2Options _options, string query)
    {
        query += query.Length > 0 ? "&" : "";
        query += $"key={_options.ApiKey}";
        return query;
    }
}