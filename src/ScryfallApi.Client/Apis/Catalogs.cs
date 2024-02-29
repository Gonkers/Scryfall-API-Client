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
    public async Task<IReadOnlyCollection<string>> ListCardNames() => (await _restService.GetAsync<Catalog>("/catalog/card-names").ConfigureAwait(false)).Data;
    public async Task<IReadOnlyCollection<string>> ListWordBank() => (await _restService.GetAsync<Catalog>("/catalog/word-bank").ConfigureAwait(false)).Data;
    public async Task<IReadOnlyCollection<string>> ListCreatureTypes() => (await _restService.GetAsync<Catalog>("/catalog/creature-types").ConfigureAwait(false)).Data;
    public async Task<IReadOnlyCollection<string>> ListPlaneswalkerTypes() => (await _restService.GetAsync<Catalog>("/catalog/planeswalker-types").ConfigureAwait(false)).Data;
    public async Task<IReadOnlyCollection<string>> ListLandTypes() => (await _restService.GetAsync<Catalog>("/catalog/land-types").ConfigureAwait(false)).Data;
    public async Task<IReadOnlyCollection<string>> ListSpellTypes() => (await _restService.GetAsync<Catalog>("/catalog/spell-types").ConfigureAwait(false)).Data;
    public async Task<IReadOnlyCollection<string>> ListEnchantmentTypes() => (await _restService.GetAsync<Catalog>("/catalog/enchantment-types").ConfigureAwait(false)).Data;
    public async Task<IReadOnlyCollection<string>> ListArtifactTypes() => (await _restService.GetAsync<Catalog>("/catalog/artifact-types").ConfigureAwait(false)).Data;
    public async Task<IReadOnlyCollection<string>> ListPowers() => (await _restService.GetAsync<Catalog>("/catalog/powers").ConfigureAwait(false)).Data;
    public async Task<IReadOnlyCollection<string>> ListToughnesses() => (await _restService.GetAsync<Catalog>("/catalog/toughnesses").ConfigureAwait(false)).Data;
    public async Task<IReadOnlyCollection<string>> ListLoyalties() => (await _restService.GetAsync<Catalog>("/catalog/loyalties").ConfigureAwait(false)).Data;
    public async Task<IReadOnlyCollection<string>> ListWatermarks() => (await _restService.GetAsync<Catalog>("/catalog/watermarks").ConfigureAwait(false)).Data;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
