namespace ScryfallApi.Client.Models;

public struct SearchOptions
{
    /// <summary>
    /// The order parameter determines how Scryfall should sort the returned cards.
    /// </summary>
    public enum CardSort
    {
        /// <summary>
        /// Sort cards by name, A → Z
        /// </summary>
        Name = 0,

        /// <summary>
        /// Sort cards by their set and collector number: AAA/#1 → ZZZ/#999
        /// </summary>
        Set = 1,

        /// <summary>
        /// Sort cards by their lowest known TIX price: 0.01 → highest, null last
        /// </summary>
        Tix = 2,

        /// <summary>
        /// Sort cards by their lowest known U.S. Dollar price: 0.01 → highest, null last
        /// </summary>
        Usd = 3,

        /// <summary>
        /// Sort cards by their lowest known Euro price: 0.01 → highest, null last
        /// </summary>
        Eur = 4,

        /// <summary>
        /// Sort cards by their converted mana cost: 0 → highest
        /// </summary>
        Cmc = 5,

        /// <summary>
        /// Sort cards by their power: null → highest
        /// </summary>
        Pow = 6,

        /// <summary>
        /// Sort cards by their toughness: null → highest
        /// </summary>
        Tou = 7,

        /// <summary>
        /// Sort cards by their rarity: Common → Mythic
        /// </summary>
        Rarity = 8,

        /// <summary>
        /// Sort cards by their color and color identity: WUBRG → multicolor → colorless
        /// </summary>
        Color = 9,

        /// <summary>
        /// Sort cards by their EDHREC ranking: lowest → highest
        /// </summary>
        EdhRec = 10,

        /// <summary>
        /// Sort cards by their release date: Newest → Oldest
        /// </summary>
        Released = 11
    }

    /// <summary>
    /// The unique parameter specifies if Scryfall should remove “duplicate” results in your query.
    /// </summary>
    public enum RollupMode
    {
        /// <summary>
        /// Removes duplicate gameplay objects (cards that share a name and have the same
        /// functionality). For example, if your search matches more than one print of
        /// Pacifism, only one copy of Pacifism will be returned.
        /// </summary>
        Cards = 0,

        /// <summary>
        /// Returns only one copy of each unique artwork for matching cards. For example,
        /// if your search matches more than one print of Pacifism, one card with each
        /// different illustration for Pacifism will be returned, but any cards that
        /// duplicate artwork already in the results will be omitted.
        /// </summary>
        Art = 1,

        /// <summary>
        /// Returns all prints for all cards matched (disables rollup). For example,
        /// if your search matches more than one print of Pacifism, all matching
        /// prints will be returned.
        /// </summary>
        Prints = 2
    }

    /// <summary>
    /// You can optionally specify a dir parameter to choose which direction the sorting should occur.
    /// </summary>
    public enum SortDirection
    {
        /// <summary>
        /// Scryfall will automatically choose the most inuitive direction to sort
        /// </summary>
        Auto = 0,

        /// <summary>
        /// Sort ascending
        /// </summary>
        Asc = 1,

        /// <summary>
        /// Sort descending
        /// </summary>
        Desc = 2
    }

    /// <summary>
    /// The direction to sort cards.
    /// </summary>
    public SortDirection Direction { get; set; }

    /// <summary>
    /// If true, extra cards (tokens, planes, etc) will be included. Equivalent to
    /// adding include:extras to the fulltext search. Defaults to false.
    /// </summary>
    public bool IncludeExtras { get; set; }

    /// <summary>
    /// If true, cards in every language supported by Scryfall will be included. Defaults to false.
    /// </summary>
    public bool IncludeMultilingual { get; set; }

    /// <summary>
    /// The strategy for omitting similar cards.
    /// </summary>
    public RollupMode Mode { get; set; }

    /// <summary>
    /// The method to sort returned cards.
    /// </summary>
    public CardSort Sort { get; set; }
    internal string BuildQueryString()
    {
        var param = new List<string>();

        if (Mode != RollupMode.Cards)
            param.Add("unique=" + Mode.ToString().ToLower());

        if (Sort != CardSort.Name)
            param.Add("order=" + Sort.ToString().ToLower());

        if (Direction != SortDirection.Auto)
            param.Add("dir=" + Direction.ToString().ToLower());

        if (IncludeExtras)
            param.Add("include_extras=true");

        if (IncludeMultilingual)
            param.Add("include_multilingual=true");

        return string.Join("&", param);
    }
}
