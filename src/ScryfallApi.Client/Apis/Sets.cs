using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using ScryfallApi.Client.Models;

namespace ScryfallApi.Client.Apis
{
    public class Sets : BaseRestService, ISets
    {
        internal Sets(HttpClient httpClient, ILogger logger, IMemoryCache cache = null) : base(httpClient, logger, cache) { }

        /// <summary>
        /// Returns a List object of all Sets on Scryfall.
        /// </summary>
        /// <returns></returns>
        public async Task<ResultList<Set>> Get() => await GetAsync<ResultList<Set>>("/sets");

        /// <summary>
        /// Returns a Set with the given set code. The code can be either the code or the mtgo_code for the set.
        /// </summary>
        /// <param name="setCode"></param>
        /// <returns></returns>
        public async Task<Set> Get(string setCode) => await GetAsync<Set>($"/sets/{setCode}");
    }
}