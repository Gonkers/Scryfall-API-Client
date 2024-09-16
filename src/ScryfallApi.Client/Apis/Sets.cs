using ScryfallApi.Client.Models;

namespace ScryfallApi.Client.Apis;

///<inheritdoc cref="ISets"/>
public class Sets : ISets
{
    private readonly BaseRestService _restService;

    internal Sets(BaseRestService restService)
    {
        _restService = restService;
    }

    ///<inheritdoc cref="ISets"/>
    public Task<ResultList<Set>?> Get() => _restService.GetAsync<ResultList<Set>>("/sets");

    ///<inheritdoc cref="ISets"/>
    public Task<Set?> Get(string setCode) => _restService.GetAsync<Set>($"/sets/{setCode}");

    ///<inheritdoc cref="ISets"/>
    public Task<Set?> Get(Guid setId) => _restService.GetAsync<Set>($"/sets/{setId}");

    ///<inheritdoc cref="ISets"/>
    public Task<Set?> GetByTcgPlayerId(int setId) => _restService.GetAsync<Set>($"/sets/tcgplayer/{setId}");
}
