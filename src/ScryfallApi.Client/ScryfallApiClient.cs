using Microsoft.Extensions.Caching.Memory;
using ScryfallApi.Client.Apis;
using System;
using System.Net.Http;

namespace ScryfallApi.Client
{
    ///<inheritdoc cref="IScryfallApiClient"/>
    public class ScryfallApiClient : IScryfallApiClient
    {
        private readonly Lazy<ICards> _cards;
        ///<inheritdoc cref="ICards"/>
        public ICards Cards => _cards.Value;

        private readonly Lazy<ISets> _sets;
        ///<inheritdoc cref="ISets"/>
        public ISets Sets => _sets.Value;

        private readonly Lazy<ICatalogs> _catalogs;
        ///<inheritdoc cref="ICatalogs"/>
        public ICatalogs Catalogs => _catalogs.Value;

        private readonly Lazy<ISymbology> _symbology;
        ///<inheritdoc cref="ISymbology"/>
        public ISymbology Symbology => _symbology.Value;

        /// <summary>
        /// Instantiate a new Scryfall API client.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="clientConfig"></param>
        /// <param name="cache"></param>
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