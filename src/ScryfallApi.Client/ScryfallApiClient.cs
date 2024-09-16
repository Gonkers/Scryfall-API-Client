using Microsoft.Extensions.Caching.Memory;
using ScryfallApi.Client.Apis;

namespace ScryfallApi.Client;

///<inheritdoc cref="IScryfallApiClient"/>
public class ScryfallApiClient : IScryfallApiClient
{
    ///<inheritdoc cref="ICards"/>
    public ICards Cards => _cards.Value;
    private readonly Lazy<ICards> _cards;

    ///<inheritdoc cref="ISets"/>
    public ISets Sets => _sets.Value;
    private readonly Lazy<ISets> _sets;

    ///<inheritdoc cref="ICatalogs"/>
    public ICatalogs Catalogs => _catalogs.Value;
    private readonly Lazy<ICatalogs> _catalogs;

    ///<inheritdoc cref="ISymbology"/>
    public ISymbology Symbology => _symbology.Value;
    private readonly Lazy<ISymbology> _symbology;

    ///<inheritdoc cref="IBulkData"/>
    public IBulkData BulkData => _bulkData.Value;
    private readonly Lazy<IBulkData> _bulkData;

    /// <summary>
    /// Instantiate a new Scryfall API client.
    /// </summary>
    /// <param name="httpClient">A standard HttpClient</param>
    /// <param name="clientConfig">Configuration settings for the client</param>
    /// <param name="cache">Memory cache for caching results from the Scryfall API</param>
    public ScryfallApiClient(HttpClient httpClient, ScryfallApiClientConfig clientConfig, IMemoryCache cache) :
        this(new(httpClient, clientConfig, cache))
    {
    }

    /// <summary>
    /// Instantiate a new Scryfall API client.
    /// </summary>
    /// <param name="httpClient">A standard HttpClient</param>
    /// <param name="clientConfig">Configuration settings for the client</param>
    public ScryfallApiClient(HttpClient httpClient, ScryfallApiClientConfig clientConfig) : 
        this(new(httpClient, clientConfig))
    {
    }

    private ScryfallApiClient(BaseRestService restService)
    {
        _cards = new(() => new Cards(restService));
        _catalogs = new(() => new Catalogs(restService));
        _sets = new(() => new Sets(restService));
        _symbology = new(() => new Symbology(restService));
        _bulkData = new(() => new BulkData(restService));
    }
}