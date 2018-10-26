using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using ScryfallApi.Client.Models;
using static ScryfallApi.Client.Models.SearchOptions;

namespace ScryfallApi.Client.Apis
{
    public class Cards : BaseRestService, ICards
    {
        internal Cards(HttpClient httpClient, ILogger logger, IMemoryCache cache = null) : base(httpClient, logger, cache) { }

        public Task<ResultList<Card>> Get(int page) => GetAsync<ResultList<Card>>($"/cards?page={page}");

        public Task<Card> GetRandom() => GetAsync<Card>($"/cards/random", false);

        public Task<ResultList<Card>> Search(string query, int page, CardSort sort) =>
            Search(query, page, new SearchOptions { Sort = sort });

        public Task<ResultList<Card>> Search(string query, int page, SearchOptions options = default)
        {
            if (page < 1) page = 1;
            query = HttpUtility.UrlEncode(query);
            return GetAsync<ResultList<Card>>($"/cards/search?q={query}&page={page}&{options.BuildQueryString()}");
        }
    }
}