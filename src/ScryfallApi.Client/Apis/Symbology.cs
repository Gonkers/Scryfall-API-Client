using ScryfallApi.Client.Models;

namespace ScryfallApi.Client.Apis;

///<inheritdoc cref="ISymbology"/>
public class Symbology : ISymbology
{
    private readonly BaseRestService _restService;

    internal Symbology(BaseRestService restService)
    {
        _restService = restService;
    }

    ///<inheritdoc cref="ISymbology"/>
    public Task<ResultList<Symbol>?> Get() => _restService.GetAsync<ResultList<Symbol>>("/symbology");

    ///<inheritdoc cref="ISymbology"/>
    public Task<ParsedManaCost?> ParseMana(string cost) => _restService.GetAsync<ParsedManaCost>($"/symbology/parse-mana?cost={cost}");
}
