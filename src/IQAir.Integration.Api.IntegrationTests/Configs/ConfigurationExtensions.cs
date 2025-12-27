using Microsoft.Extensions.Configuration;

namespace IQAir.Integration.Api.IntegrationTests.Configs;

public static class ConfigurationExtensions
{
    public static ConfigurationBuilder AddTestConfigurations(
        this ConfigurationBuilder builder, 
        params KeyValuePair<string, string>[][] configurations)
    {
        foreach (var configuration in configurations)
        {
            builder.AddInMemoryCollection(configuration!);
        }
        
        return builder;
    }
}