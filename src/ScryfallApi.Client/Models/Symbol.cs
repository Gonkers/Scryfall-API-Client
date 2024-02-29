using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

public class Symbol : BaseItem
{
    /// <summary>
    /// The plaintext symbol. Often surrounded with curly braces {}. Note that not all symbols
    /// are ASCII text (for example, {∞}).
    /// </summary>
    [JsonPropertyName("symbol")]
    public string Text { get; init; }

    /// <summary>
    /// An alternate version of this symbol, if it is possible to write it without curly braces.
    /// </summary>
    [JsonPropertyName("loose_variant")]
    public string? LooseVariant { get; init; }

    /// <summary>
    /// An English snippet that describes this symbol. Appropriate for use in alt text or other
    /// accessible communication formats.
    /// </summary>
    [JsonPropertyName("english")]
    public string Description { get; init; }

    /// <summary>
    /// True if it is possible to write this symbol “backwards”. For example, the official symbol
    /// {U/P} is sometimes written as {P/U} or {P\U} in informal settings. Note that the Scryfall
    /// API never writes symbols backwards in other responses. This field is provided for informational
    /// purposes.
    /// </summary>
    [JsonPropertyName("transposable")]
    public bool IsTransposable { get; init; }

    /// <summary>
    /// True if this is a mana symbol.
    /// </summary>
    [JsonPropertyName("represents_mana")]
    public bool IsManaSymbol { get; init; }

    /// <summary>
    /// A decimal number representing this symbol’s mana value (also knowns as the converted mana
    /// cost). Note that mana symbols from funny sets can have fractional mana values.
    /// </summary>
    [JsonPropertyName("mana_value")]
    public decimal? ManaValue { get; init; }

    /// <summary>
    /// True if this symbol appears in a mana cost on any Magic card. For example {20} has this field
    /// set to false because {20} only appears in Oracle text, not mana costs.
    /// </summary>
    [JsonPropertyName("appears_in_mana_costs")]
    public bool AppearsInManaCosts { get; init; }

    /// <summary>
    /// True if this symbol is only used on funny cards or Un-cards.
    /// </summary>
    [JsonPropertyName("funny")]
    public bool IsFunny { get; init; }

    /// <summary>
    /// An array of colors that this symbol represents.
    /// </summary>
    [JsonPropertyName("colors")]
    public IReadOnlyCollection<string> Colors { get; init; } = [];

    ///<summary>
    /// True if the symbol is a hybrid mana symbol. Note that monocolor Phyrexian symbols aren’t
    /// considered hybrid.
    ///</summary>
    [JsonPropertyName("hybrid")]
    public bool IsHybrid { get; init; }

    ///<summary>
    /// True if the symbol is a Phyrexian mana symbol, i.e. it can be paid with 2 life.
    ///</summary>
    [JsonPropertyName("phyrexian")]
    public bool IsPhyrexian { get; init; }

    ///<summary>
    /// An array of plaintext versions of this symbol that Gatherer uses on old cards to describe
    /// original printed text. For example: {W} has ["oW", "ooW"] as alternates.
    ///</summary>
    [JsonPropertyName("gatherer_alternates")]
    public string? gatherer_alternates { get; init; }

    ///<summary>
    /// A URI to an SVG image of this symbol on Scryfall’s CDNs.
    ///</summary>
    [JsonPropertyName("svg_uri")]
    public Uri? svg_uri { get; init; }
}
