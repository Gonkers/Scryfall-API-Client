namespace ScryfallApi.Client;

/// <summary>
/// Configuration options for the Scryfall API client.
/// </summary>
public record ScryfallApiClientConfig
{
    /// <summary>
    /// The default address for the Scryfall API.
    /// </summary>
    public const string ScryfallApiAddress = "https://api.scryfall.com/";

    /// <summary>
    /// The base address for the Scryfall API. Defaults to https://api.scryfall.com/
    /// </summary>
    public Uri ScryfallApiBaseAddress { get; init; } = new Uri(ScryfallApiAddress);

    /// <summary>
    /// For cacheable endpoints, the duration to cache API responses. Defaults to 30 minutes.
    /// </summary>
    public TimeSpan CacheDuration { get; init; } = TimeSpan.FromMinutes(30);

    /// <summary>
    /// For cacheable endpoints, use sliding cache expiration instead of absolute expiration. Defaults to false.
    /// </summary>
    public bool UseSlidingCacheExpiration { get; init; } = false;

    /// <summary>
    /// The default configuration for the Scryfall API client.
    /// </summary>
    /// <returns>ScryfallApiClientConfig</returns>
    public static ScryfallApiClientConfig GetDefault() => new();
}
