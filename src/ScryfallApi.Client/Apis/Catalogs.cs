using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using ScryfallApi.Client.Models;

namespace ScryfallApi.Client.Apis
{
    public class Catalogs : BaseRestService, ICatalogs
    {
        internal Catalogs(HttpClient httpClient, ILogger logger, IMemoryCache cache = null) : base(httpClient, logger, cache) { }

        public async Task<string[]> ListCardNames() => (await GetAsync<Catalog>("/catalog/card-names")).Data;
        public async Task<string[]> ListWordBank() => (await GetAsync<Catalog>("/catalog/word-bank")).Data;
        public async Task<string[]> ListCreatureTypes() => (await GetAsync<Catalog>("/catalog/creature-types")).Data;
        public async Task<string[]> ListPlaneswalkerTypes() => (await GetAsync<Catalog>("/catalog/planeswalker-types")).Data;
        public async Task<string[]> ListLandTypes() => (await GetAsync<Catalog>("/catalog/land-types")).Data;
        public async Task<string[]> ListSpellTypes() => (await GetAsync<Catalog>("/catalog/spell-types")).Data;
        public async Task<string[]> ListEnchantmentTypes() => (await GetAsync<Catalog>("/catalog/enchantment-types")).Data;
        public async Task<string[]> ListArtifactTypes() => (await GetAsync<Catalog>("/catalog/artifact-types")).Data;
        public async Task<string[]> ListPowers() => (await GetAsync<Catalog>("/catalog/powers")).Data;
        public async Task<string[]> ListToughnesses() => (await GetAsync<Catalog>("/catalog/toughnesses")).Data;
        public async Task<string[]> ListLoyalties() => (await GetAsync<Catalog>("/catalog/loyalties")).Data;
        public async Task<string[]> ListWatermarks() => (await GetAsync<Catalog>("/catalog/watermarks")).Data;
    }
}