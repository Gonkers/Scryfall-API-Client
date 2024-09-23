using System.Net;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using NSubstitute;

namespace ScryfallApi.Client.Tests;

public class BaseRestServiceTests
{
    [Fact]
    public async Task GetAsync_ThrowsWhenResourceUrlIsEmpty()
    {
        var mockHandler = new MockHttpMessageHandler();
        BaseRestService service = new(mockHandler.ToHttpClient(), ScryfallApiClientConfig.GetDefault(), default!);

        await Assert.ThrowsAsync<ArgumentNullException>(() =>
            service.GetAsync<BaseItem>("", false));
    }

    [Fact]
    public async Task GetAsync_ReturnsDataFromCacheWhenEnabled()
    {
        const string
            testEndpoint = "/test-endpoint",
            cacheKey = ScryfallApiClientConfig.ScryfallApiAddress + testEndpoint;
        var cache = new MemoryCache(Options.Create(new MemoryCacheOptions()));
        var cachedItem = new Set { Id = Guid.NewGuid(), Name = "Test Set", Code = "tst" };
        cache.Set(cacheKey, cachedItem);
        var httpClient = Substitute.For<HttpClient>();

        BaseRestService service = new(httpClient, ScryfallApiClientConfig.GetDefault(), cache);
        var result = await service.GetAsync<Set>(testEndpoint, true);

        Assert.Same(cachedItem, result);
        Assert.Empty(httpClient.ReceivedCalls());
    }

    [Fact]
    public async Task GetAsync_ReturnsDataFromApiWhenNotInCache()
    {
        const string testEndpoint = "/test-endpoint";

        var cache = new MemoryCache(Options.Create(new MemoryCacheOptions()));
        var mockHandler = new MockHttpMessageHandler();
        mockHandler
            .Expect(HttpMethod.Get, testEndpoint)
            .Respond("application/json", "{ \"name\": \"Test Set\", \"code\": \"tst\" }");

        BaseRestService service = new(mockHandler.ToHttpClient(), ScryfallApiClientConfig.GetDefault(), cache);
        var result = await service.GetAsync<Set>(testEndpoint, true);

        Assert.NotNull(result);
        Assert.Equal("Test Set", result.Name);
        Assert.Equal("tst", result.Code);

        mockHandler.VerifyNoOutstandingExpectation();
    }

    [Fact]
    public async Task GetAsync_ThrowsWhenApiReturnsHttpError()
    {
        const string testEndpoint = "/sets/tst";
        var cache = new MemoryCache(Options.Create(new MemoryCacheOptions()));
        var mockHandler = new MockHttpMessageHandler();
        const string scryfallNotFoundJson = @"
            {
                ""object"": ""error"",
                ""code"": ""not_found"",
                ""status"": 404,
                ""details"": ""No Magic set found for the given code or ID""
            }";
        mockHandler
            .Expect(HttpMethod.Get, testEndpoint)
            .Respond(HttpStatusCode.BadRequest, "application/json", scryfallNotFoundJson);

        BaseRestService service = new(mockHandler.ToHttpClient(), ScryfallApiClientConfig.GetDefault(), cache);

        var ex = await Assert.ThrowsAsync<HttpRequestException>(() =>
            service.GetAsync<Set>(testEndpoint, true));

        Assert.Equal(HttpStatusCode.BadRequest, ex.StatusCode);

        mockHandler.VerifyNoOutstandingExpectation();
    }

    [Fact]
    public async Task GetAsync_ThrowsWhenApiReturnsScryfallError()
    {
        const string testEndpoint = "/sets/tst";
        var cache = new MemoryCache(Options.Create(new MemoryCacheOptions()));
        var mockHandler = new MockHttpMessageHandler();
        const string scryfallNotFoundJson = @"
            {
                ""object"": ""error"",
                ""code"": ""not_found"",
                ""status"": 404,
                ""details"": ""No Magic set found for the given code or ID""
            }";
        mockHandler
            .Expect(HttpMethod.Get, testEndpoint)
            .Respond(HttpStatusCode.OK, "application/json", scryfallNotFoundJson);

        BaseRestService service = new(mockHandler.ToHttpClient(), ScryfallApiClientConfig.GetDefault(), cache);

        var ex = await Assert.ThrowsAsync<ScryfallApiException>(() =>
            service.GetAsync<Set>(testEndpoint, true));

        Assert.Equal(HttpStatusCode.OK, ex.ResponseStatusCode);
        Assert.Equal("error", ex.ScryfallError.ObjectType);
        Assert.Equal("not_found", ex.ScryfallError.Code);
        Assert.Equal(404, ex.ScryfallError.Status);
        Assert.Equal("No Magic set found for the given code or ID", ex.ScryfallError.Details);

        mockHandler.VerifyNoOutstandingExpectation();
    }

    [Fact]
    public async Task GetAsync_AddsItemsToCacheWhenEnabled()
    {
        const string testEndpoint = "/sets/tst",
            cacheKey = ScryfallApiClientConfig.ScryfallApiAddress + testEndpoint;
        var cache = new MemoryCache(Options.Create(new MemoryCacheOptions()));
        var mockHandler = new MockHttpMessageHandler();
        mockHandler
            .Expect(HttpMethod.Get, testEndpoint)
            .Respond("application/json", "{ \"name\": \"Test Set\", \"code\": \"tst\" }");

        BaseRestService service = new(mockHandler.ToHttpClient(), ScryfallApiClientConfig.GetDefault(), cache);
        var result = await service.GetAsync<Set>(testEndpoint, true);

        var value = cache.Get<Set>(cacheKey);
        Assert.NotNull(value);
        Assert.Equal("Test Set", value.Name);
        Assert.Equal("tst", value.Code);
        mockHandler.VerifyNoOutstandingExpectation();
    }
}