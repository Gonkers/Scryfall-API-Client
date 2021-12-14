using ScryfallApi.Client.Models;

namespace ScryfallApi.Client.Apis;

///<inheritdoc cref="IBulkData"/>
public class BulkData : IBulkData
{
    private readonly BaseRestService _restService;

    internal BulkData(BaseRestService restService)
    {
        _restService = restService;
    }

    public Task<ResultList<BulkDataItem>> Get() => _restService.GetAsync<ResultList<BulkDataItem>>("/bulk-data", false);

    public async Task<ICollection<BulkDataItem>> Get(DateTimeOffset updatedSince)
    {
        var bulkData = await Get();
        return bulkData.Data.Where(d => d.LastUpdated >= updatedSince).ToList();
    }

    public async Task<BulkDataItem> Get(DateTimeOffset updatedSince, string bulkDataType) => 
        (await Get(updatedSince)).FirstOrDefault(d => d.Type.Equals(bulkDataType, StringComparison.OrdinalIgnoreCase));

    public static class Types
    {
        /// <summary>
        /// A JSON file containing one Scryfall card object for each Oracle ID on Scryfall. The 
        /// chosen sets for the cards are an attempt to return the most up-to-date recognizable 
        /// version of the card.
        /// </summary>
        public static string OracleCards  => "oracle_cards";

        /// <summary>
        /// A JSON file of Scryfall card objects that together contain all unique artworks. The 
        /// chosen cards promote the best image scans.
        /// </summary>
        public static string UniqueArtwork  => "unique_artwork";

        /// <summary>
        /// A JSON file containing every card object on Scryfall in English or the printed 
        /// language if the card is only available in one language.
        /// </summary>
        public static string DefaultCards => "default_cards";

        /// <summary>
        /// A JSON file containing every card object on Scryfall in every language.
        /// </summary>
        public static string AllCards  => "all_cards";

        /// <summary>
        /// A JSON file containing all Rulings on Scryfall. Each ruling refers to cards via an `oracle_id`.
        /// </summary>
        public static string Rulings => "rulings";
    }
}
