using System.Threading.Tasks;
using ScryfallApi.Client.Models;

namespace ScryfallApi.Client.Apis
{
    public interface ICards
    {
        Task<ResultList<Card>> Get(int page);
        Task<ResultList<Card>> Search(string query, int page, CardSort sort);
        Task<Card> GetRandom();
    }
}