namespace ScryfallApi.Client.Apis;

/// <summary>
/// A Catalog object contains an array of Magic datapoints (words, card values, etc). Catalog objects
/// are provided by the API as aids for building other Magic software and understanding possible
/// values for a field on Card objects.
/// </summary>
public interface ICatalogs
{
    /// <summary>
    /// Returns a list of all nontoken English card names in Scryfall’s database. Values are updated as
    /// soon as a new card is entered for spoiler seasons.
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyCollection<string>> ListCardNames();

    /// <summary>
    /// Returns a Catalog of all English words, of length 2 or more, that could appear in a card name.
    /// Values are drawn from cards currently in Scryfall’s database. Values are updated as soon as a
    /// new card is entered for spoiler seasons.
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyCollection<string>> ListWordBank();

    /// <summary>
    /// Returns a Catalog of all creature types in Scryfall’s database. Values are updated as soon as
    /// a new card is entered for spoiler seasons.
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyCollection<string>> ListCreatureTypes();

    /// <summary>
    /// Returns a Catalog of all Planeswalker types in Scryfall’s database. Values are updated as soon as
    /// a new card is entered for spoiler seasons.
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyCollection<string>> ListPlaneswalkerTypes();

    /// <summary>
    /// Returns a Catalog of all Land types in Scryfall’s database. Values are updated as soon as a new
    /// card is entered for spoiler seasons.
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyCollection<string>> ListLandTypes();

    /// <summary>
    /// Returns a Catalog of all spell types in Scryfall’s database. Values are updated as soon as a new
    /// card is entered for spoiler seasons.
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyCollection<string>> ListSpellTypes();

    /// <summary>
    /// Returns a Catalog of all artifact types in Scryfall’s database. Values are updated as soon as a
    /// new card is entered for spoiler seasons.
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyCollection<string>> ListArtifactTypes();

    /// <summary>
    /// Returns a Catalog of all enchantment types in Scryfall’s database. Values are updated as soon as a
    /// new card is entered for spoiler seasons.
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyCollection<string>> ListEnchantmentTypes();

    /// <summary>
    /// Returns a Catalog of all possible values for a creature or vehicle’s power in Scryfall’s database.
    /// Values are updated as soon as a new card is entered for spoiler seasons.
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyCollection<string>> ListPowers();

    /// <summary>
    /// Returns a Catalog of all possible values for a creature or vehicle’s toughness in Scryfall’s database.
    /// Values are updated as soon as a new card is entered for spoiler seasons.
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyCollection<string>> ListToughnesses();

    /// <summary>
    /// Returns a Catalog of all possible values for a Planeswalker’s loyalty in Scryfall’s database. Values
    /// are updated as soon as a new card is entered for spoiler seasons.
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyCollection<string>> ListLoyalties();

    /// <summary>
    /// Returns a Catalog of all card watermarks in Scryfall’s database. Values are updated as soon as a new
    /// card is entered for spoiler seasons.
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyCollection<string>> ListWatermarks();
}
