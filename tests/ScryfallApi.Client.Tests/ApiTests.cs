using System.Text;

namespace ScryfallApi.Client.Tests;

public class ApiTests
{
    [Fact]
    public async Task ScryfallApiClient_EndpointsAreMappedCorrectly()
    {
        var guid = Guid.NewGuid();

        await ExpectHttpRequest("/bulk-data", c => c.BulkData.Get());
        await ExpectHttpRequest("/bulk-data", c => c.BulkData.Get(DateTimeOffset.Now));
        await ExpectHttpRequest("/bulk-data", c => c.BulkData.Get(DateTimeOffset.Now, "bulkDataType"));

        await ExpectHttpRequest("/cards?page=1", c => c.Cards.Get(1));
        await ExpectHttpRequest("/cards/random", c => c.Cards.GetRandom());
        await ExpectHttpRequest("/cards/search?q=query&page=2&order=cmc",
            c => c.Cards.Search("query", 2, SearchOptions.CardSort.Cmc));
        await ExpectHttpRequest("/cards/search?q=query&order=released",
            c => c.Cards.Search("query", new() { Sort = SearchOptions.CardSort.Released }));
        await ExpectHttpRequest("/catalog/card-names", c => c.Catalogs.ListCardNames());
        await ExpectHttpRequest("/catalog/word-bank", c => c.Catalogs.ListWordBank());
        await ExpectHttpRequest("/catalog/creature-types", c => c.Catalogs.ListCreatureTypes());
        await ExpectHttpRequest("/catalog/planeswalker-types", c => c.Catalogs.ListPlaneswalkerTypes());
        await ExpectHttpRequest("/catalog/land-types", c => c.Catalogs.ListLandTypes());
        await ExpectHttpRequest("/catalog/spell-types", c => c.Catalogs.ListSpellTypes());
        await ExpectHttpRequest("/catalog/enchantment-types", c => c.Catalogs.ListEnchantmentTypes());
        await ExpectHttpRequest("/catalog/artifact-types", c => c.Catalogs.ListArtifactTypes());
        await ExpectHttpRequest("/catalog/powers", c => c.Catalogs.ListPowers());
        await ExpectHttpRequest("/catalog/toughnesses", c => c.Catalogs.ListToughnesses());
        await ExpectHttpRequest("/catalog/loyalties", c => c.Catalogs.ListLoyalties());
        await ExpectHttpRequest("/catalog/watermarks", c => c.Catalogs.ListWatermarks());

        await ExpectHttpRequest("/sets", c => c.Sets.Get());
        await ExpectHttpRequest("/sets/code", c => c.Sets.Get("code"));
        await ExpectHttpRequest("/sets/" + guid, c => c.Sets.Get(guid));
        await ExpectHttpRequest("/sets/tcgplayer/1234", c => c.Sets.GetByTcgPlayerId(1234));

        await ExpectHttpRequest("/symbology", c => c.Symbology.Get());
        await ExpectHttpRequest("/symbology/parse-mana?cost=RUx", c => c.Symbology.ParseMana("RUx"));
    }

    private static async Task<MockHttpMessageHandler> ExpectHttpRequest(string endpoint,
        Func<IScryfallApiClient, Task> action)
    {
        var mockHandler = new MockHttpMessageHandler();
        mockHandler
            .Expect(HttpMethod.Get, endpoint)
            .Respond(request => new()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Content = new StringContent("{}", Encoding.UTF8, "application/json")
            });

        var client = new ScryfallApiClient(mockHandler.ToHttpClient(), ScryfallApiClientConfig.GetDefault());
        await action(client);
        mockHandler.VerifyNoOutstandingExpectation();
        return mockHandler;
    }
}