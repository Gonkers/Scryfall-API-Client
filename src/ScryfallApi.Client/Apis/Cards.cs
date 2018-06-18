using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using ScryfallApi.Client.Models;

namespace ScryfallApi.Client.Apis
{
    public class Cards : BaseRestService, ICards
    {
        internal Cards(HttpClient httpClient, ILogger logger, IMemoryCache cache = null) : base(httpClient, logger, cache) { }

        public async Task<ResultList<Card>> Get(int page) => await GetAsync<ResultList<Card>>($"/cards?page={page}");
        public async Task<Card> GetRandom() => await GetAsync<Card>($"/cards/random", false);



        public Task<ResultList<Card>> Search(string query, int page, CardSort sort) => throw new NotImplementedException();
    }
}