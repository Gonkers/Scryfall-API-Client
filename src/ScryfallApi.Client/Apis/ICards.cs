using ScryfallApi.Client.Models;
using static ScryfallApi.Client.Models.SearchOptions;

namespace ScryfallApi.Client.Apis;

/// <summary>
/// APIs for cards. Card objects represent individual Magic: The Gathering cards that players could
/// obtain and add to their collection (with a few minor exceptions).
/// </summary>
public interface ICards
{
    /// <summary>
    /// Fetch a card at random.
    /// </summary>
    /// <returns></returns>
    Task<Card?> GetRandom();

    /// <summary>
    /// Get a page worth of cards
    /// </summary>
    /// <param name="page"></param>
    /// <returns></returns>
    Task<ResultList<Card>?> Get(int page);

    /// <summary>
    /// Search for cards with a sort option
    /// </summary>
    /// <param name="query"></param>
    /// <param name="page"></param>
    /// <param name="sort"></param>
    /// <returns></returns>
    Task<ResultList<Card>?> Search(string query, int page, CardSort sort);

    /// <summary>
    /// Search for cards using the full search options available
    /// </summary>
    /// <param name="query"></param>
    /// <param name="page"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    Task<ResultList<Card>?> Search(string query, int page, SearchOptions options);
}
