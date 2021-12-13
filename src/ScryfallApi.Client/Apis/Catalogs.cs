using ScryfallApi.Client.Models;

namespace ScryfallApi.Client.Apis;

///<inheritdoc cref="ICatalogs"/>
public class Catalogs : ICatalogs
{
    private readonly BaseRestService _restService;

    internal Catalogs(BaseRestService restService)
    {
        _restService = restService;
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public async Task<string[]> ListCardNames() => (await _restService.GetAsync<Catalog>("/catalog/card-names").ConfigureAwait(false)).Data;
    public async Task<string[]> ListWordBank() => (await _restService.GetAsync<Catalog>("/catalog/word-bank").ConfigureAwait(false)).Data;
    public async Task<string[]> ListCreatureTypes() => (await _restService.GetAsync<Catalog>("/catalog/creature-types").ConfigureAwait(false)).Data;
    public async Task<string[]> ListPlaneswalkerTypes() => (await _restService.GetAsync<Catalog>("/catalog/planeswalker-types").ConfigureAwait(false)).Data;
    public async Task<string[]> ListLandTypes() => (await _restService.GetAsync<Catalog>("/catalog/land-types").ConfigureAwait(false)).Data;
    public async Task<string[]> ListSpellTypes() => (await _restService.GetAsync<Catalog>("/catalog/spell-types").ConfigureAwait(false)).Data;
    public async Task<string[]> ListEnchantmentTypes() => (await _restService.GetAsync<Catalog>("/catalog/enchantment-types").ConfigureAwait(false)).Data;
    public async Task<string[]> ListArtifactTypes() => (await _restService.GetAsync<Catalog>("/catalog/artifact-types").ConfigureAwait(false)).Data;
    public async Task<string[]> ListPowers() => (await _restService.GetAsync<Catalog>("/catalog/powers").ConfigureAwait(false)).Data;
    public async Task<string[]> ListToughnesses() => (await _restService.GetAsync<Catalog>("/catalog/toughnesses").ConfigureAwait(false)).Data;
    public async Task<string[]> ListLoyalties() => (await _restService.GetAsync<Catalog>("/catalog/loyalties").ConfigureAwait(false)).Data;
    public async Task<string[]> ListWatermarks() => (await _restService.GetAsync<Catalog>("/catalog/watermarks").ConfigureAwait(false)).Data;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
