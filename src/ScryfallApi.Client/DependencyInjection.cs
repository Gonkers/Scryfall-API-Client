using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ScryfallApi.Client;

/// <summary>
/// Extension methods for adding the Scryfall API client to the service collection.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Adds the Scryfall API client to the service collection with the default configuration.
    /// </summary>
    /// <param name="services">The DI Service Collection</param>
    /// <returns>IHttpClientBuilder</returns>
    public static IHttpClientBuilder AddScryfallApiClient(this IServiceCollection services) =>
        AddScryfallApiClient(services, ScryfallApiClientConfig.GetDefault());

    /// <summary>
    /// Adds the Scryfall API client to the service collection with the default configuration.
    /// </summary>
    /// <param name="services">The DI Service Collection</param>
    /// <param name="config">The configuration block containing the section "ScryfallApiClient" or the section itself.</param>
    /// <returns>IHttpClientBuilder</returns>
    public static IHttpClientBuilder AddScryfallApiClient(this IServiceCollection services, IConfiguration config)
    {
        // If the section ScryfallApiClient exists, use it, otherwise use the root configuration
        config = config.GetChildren().FirstOrDefault(x => x.Key == nameof(ScryfallApiClient)) as IConfiguration ?? config;
        var scryfallConfig = config.Get<ScryfallApiClientConfig>();
        return AddScryfallApiClient(services, scryfallConfig ?? ScryfallApiClientConfig.GetDefault());
    }

    /// <summary>
    /// Adds the Scryfall API client to the service collection with the specified configuration.
    /// </summary>
    /// <param name="services">The DI Service Collection</param>
    /// <param name="clientConfig">Customized API client configuration</param>
    /// <returns>IHttpClientBuilder</returns>
    public static IHttpClientBuilder AddScryfallApiClient(this IServiceCollection services, ScryfallApiClientConfig clientConfig)
    {
        services.AddSingleton(_ => clientConfig);
        return services.AddHttpClient<ScryfallApiClient>(client =>
            client.BaseAddress = clientConfig.ScryfallApiBaseAddress);
    }
}
