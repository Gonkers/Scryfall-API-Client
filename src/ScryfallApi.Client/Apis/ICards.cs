using System.Threading.Tasks;
using ScryfallApi.Client.Models;
using static ScryfallApi.Client.Models.SearchOptions;

namespace ScryfallApi.Client.Apis
{
    public interface ICards
    {
        Task<Card> GetRandom();
        Task<ResultList<Card>> Get(int page);
        Task<ResultList<Card>> Search(string query, int page, CardSort sort);
        Task<ResultList<Card>> Search(string query, int page, SearchOptions options);
    }
}