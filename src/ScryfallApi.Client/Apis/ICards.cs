using System.Threading.Tasks;
using ScryfallApi.Client.Models;
using static ScryfallApi.Client.Models.SearchOptions;

namespace ScryfallApi.Client.Apis
{
    /// <summary>
    /// APIs for cards. Card objects represent individual Magic: The Gathering cards that players could
    /// obtain and add to their collection (with a few minor exceptions).
    /// </summary>
    public interface ICards
    {
        Task<Card> GetRandom();
        Task<ResultList<Card>> Get(int page);
        Task<ResultList<Card>> Search(string query, int page, CardSort sort);
        Task<ResultList<Card>> Search(string query, int page, SearchOptions options);
    }
}