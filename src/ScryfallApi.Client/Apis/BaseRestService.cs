using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ScryfallApi.Client.Apis
{
    public abstract class BaseRestService
    {
        protected HttpClient _httpClient { get; }
        protected IMemoryCache _cache { get; }
        protected ILogger _logger { get; }

        protected BaseRestService(HttpClient httpClient, ILogger logger = null, IMemoryCache cache = null)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _logger = logger;
            _cache = cache;
        }

        protected async Task<T> GetAsync<T>(string resourceUrl, bool useCache = true)
        {
            if (string.IsNullOrWhiteSpace(resourceUrl))
                throw new ArgumentNullException(nameof(resourceUrl));

            // Naive approach to caching
            var cacheKey = _httpClient.BaseAddress.AbsoluteUri + resourceUrl;

            if (useCache)
            {
                if (_cache != null && _cache.TryGetValue(cacheKey, out T cached))
                {
                    _logger?.LogDebug("Cache hit: {0}", cacheKey);
                    return cached;
                }

                _logger?.LogDebug("Cache miss: {0}", cacheKey);
            }

            _logger?.LogDebug("Retrieving URI: {0}", cacheKey);
            var response = await _httpClient.GetAsync(resourceUrl).ConfigureAwait(false);
            _logger?.LogDebug("Response code: {0}", response.StatusCode);
            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException(); // TODO: Return a message

            var json = await response.Content.ReadAsStringAsync();
            _logger?.LogTrace("Response text: {0}", json);
            // TODO: The scryfall API can sometimes return an Error object, detect it and throw
            var obj = JsonConvert.DeserializeObject<T>(json);
            _cache?.Set(_httpClient.BaseAddress.AbsoluteUri + resourceUrl, obj);

            return obj;
        }
    }
}