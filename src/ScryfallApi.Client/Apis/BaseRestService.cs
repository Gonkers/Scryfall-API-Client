using Microsoft.Extensions.Caching.Memory;
using ScryfallApi.Client.Models;
using System.Text.Json;

namespace ScryfallApi.Client.Apis;

internal sealed class BaseRestService
{
    private readonly HttpClient _httpClient;
    private readonly ScryfallApiClientConfig _clientConfig;
    private readonly IMemoryCache _cache;
    private readonly MemoryCacheEntryOptions _cacheOptions;

    public BaseRestService(HttpClient httpClient, ScryfallApiClientConfig clientConfig, IMemoryCache cache)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _httpClient.BaseAddress ??= clientConfig.ScryfallApiBaseAddress;
        _clientConfig = clientConfig;
        _cache = cache;
        _cacheOptions = new MemoryCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = _clientConfig.UseSlidingCacheExpiration ? null : _clientConfig.CacheDuration,
            SlidingExpiration = _clientConfig.UseSlidingCacheExpiration ? _clientConfig.CacheDuration : null,
        };
    }

    public async Task<T?> GetAsync<T>(string resourceUrl, bool useCache = true) where T : BaseItem
    {
        if (string.IsNullOrWhiteSpace(resourceUrl))
            throw new ArgumentNullException(nameof(resourceUrl));

        var baseAddress = _httpClient.BaseAddress?.AbsoluteUri ?? ScryfallApiClientConfig.ScryfallApiAddress;
        var cacheKey = baseAddress + resourceUrl;

        if (useCache && _cache.TryGetValue(cacheKey, out T? cached) && cached is not null)
            return cached;

        var request = new HttpRequestMessage(HttpMethod.Get, resourceUrl);
        var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        var jsonStream = await response.Content.ReadAsStreamAsync();
        var obj = await JsonSerializer.DeserializeAsync<T>(jsonStream);

        if (obj?.ObjectType.Equals("error", StringComparison.OrdinalIgnoreCase) ?? false)
        {
            jsonStream.Position = 0;
            var error = await JsonSerializer.DeserializeAsync<Error>(jsonStream);
            throw new ScryfallApiException(error?.Details ?? "An unknown response was returned from the API.")
            {
                ResponseStatusCode = response.StatusCode,
                RequestUri = request.RequestUri ?? new(ScryfallApiClientConfig.ScryfallApiAddress),
                RequestMethod = request.Method,
                ScryfallError = error ?? new()
            };
        }

        if (useCache) _cache?.Set(cacheKey, obj, _cacheOptions);

        return obj;
    }
}
