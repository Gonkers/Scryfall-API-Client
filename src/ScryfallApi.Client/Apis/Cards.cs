using ScryfallApi.Client.Models;
using System.Net;
using static ScryfallApi.Client.Models.SearchOptions;

namespace ScryfallApi.Client.Apis;

///<inheritdoc cref="ICards"/>
public class Cards : ICards
{
    private readonly BaseRestService _restService;

    internal Cards(BaseRestService restService)
    {
        _restService = restService;
    }

    ///<inheritdoc cref="ICards"/>
    public Task<ResultList<Card>?> Get(int page) => _restService.GetAsync<ResultList<Card>>($"/cards?page={page}");

    ///<inheritdoc cref="ICards"/>
    public Task<Card?> GetRandom() => _restService.GetAsync<Card>("/cards/random", false);

    ///<inheritdoc cref="ICards"/>
    public Task<ResultList<Card>?> Search(string query, int page, CardSort sort) =>
        Search(query, new() { Page = page, Sort = sort });

    ///<inheritdoc cref="ICards"/>
    public Task<ResultList<Card>?> Search(string query, SearchOptions options = default)
    {
        if (string.IsNullOrWhiteSpace(query))
            throw new ArgumentException($"The parameter {nameof(query)} cannot be null or empty", nameof(query));
        
        return _restService.GetAsync<ResultList<Card>>($"/cards/search?q={WebUtility.UrlEncode(query)}{options}");
    }
}