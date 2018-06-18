using System;
using System.Net.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using ScryfallApi.Client.Apis;

namespace ScryfallApi.Client
{
    public class ScryfallApiClient
    {
        Lazy<ICards> _cards { get; }
        public ICards Cards => _cards.Value;

        Lazy<ISets> _sets { get; }
        public ISets Sets => _sets.Value;

        Lazy<ICatalogs> _catalogs { get; }
        public ICatalogs Catalogs => _catalogs.Value;

        Lazy<ISymbology> _symbology { get; }
        public ISymbology Symbology => _symbology.Value;

        /// <summary>
        /// Instantiate a new Scryfall API client.
        /// </summary>
        /// <param name="baseUrlConnectionString">URL for Scryfall API</param>
        public ScryfallApiClient(HttpClient httpClient, ILogger<ScryfallApiClient> logger, IMemoryCache cache = null)
        {
            _cards = new Lazy<ICards>(() => new Cards(httpClient, logger));
            _sets = new Lazy<ISets>(() => new Sets(httpClient, logger));
            _catalogs = new Lazy<ICatalogs>(() => new Catalogs(httpClient, logger, cache));
            _cards = new Lazy<ICards>(() => new Cards(httpClient, logger, cache));
            _symbology = new Lazy<ISymbology>(() => new Symbology(httpClient, logger, cache));
        }
    }
}