using Microsoft.Extensions.Caching.Memory;
using ScryfallApi.Client.Apis;
using System;
using System.Net.Http;

namespace ScryfallApi.Client
{
    public class ScryfallApiClient : IScryfallApiClient
    {
        private readonly Lazy<ICards> _cards;
        public ICards Cards => _cards.Value;

        private readonly Lazy<ISets> _sets;
        public ISets Sets => _sets.Value;

        private readonly Lazy<ICatalogs> _catalogs;
        public ICatalogs Catalogs => _catalogs.Value;

        private readonly Lazy<ISymbology> _symbology;
        public ISymbology Symbology => _symbology.Value;

        /// <summary>
        /// Instantiate a new Scryfall API client.
        /// </summary>
        /// <param name="baseUrlConnectionString">URL for Scryfall API</param>
        public ScryfallApiClient(HttpClient httpClient, ScryfallApiClientConfig clientConfig = null, IMemoryCache cache = null)
        {
            if (clientConfig is null)
            {
                clientConfig = ScryfallApiClientConfig.GetDefault();
                clientConfig.EnableCaching = cache is not null;
            }

            var restService = new BaseRestService(httpClient, clientConfig, cache);
            _cards = new Lazy<ICards>(() => new Cards(restService));
            _catalogs = new Lazy<ICatalogs>(() => new Catalogs(restService));
            _sets = new Lazy<ISets>(() => new Sets(restService));
            _symbology = new Lazy<ISymbology>(() => new Symbology(restService));
        }
    }
}