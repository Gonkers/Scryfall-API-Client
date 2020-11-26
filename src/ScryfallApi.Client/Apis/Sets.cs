using ScryfallApi.Client.Models;
using System.Threading.Tasks;

namespace ScryfallApi.Client.Apis
{
    public class Sets : ISets
    {
        private readonly BaseRestService _restService;

        internal Sets(BaseRestService restService)
        {
            _restService = restService;
        }

        /// <summary>
        /// Returns a List object of all Sets on Scryfall.
        /// </summary>
        /// <returns></returns>
        public Task<ResultList<Set>> Get() => _restService.GetAsync<ResultList<Set>>("/sets");

        /// <summary>
        /// Returns a Set with the given set code. The code can be either the code or the mtgo_code for the set.
        /// </summary>
        /// <param name="setCode"></param>
        /// <returns></returns>
        public Task<Set> Get(string setCode) => _restService.GetAsync<Set>($"/sets/{setCode}");
    }
}