using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

/// <summary>
/// The parsed mana cost of the /symbology/parse-mana endpoint.
/// </summary>
public class ParsedManaCost : BaseItem
{
    /// <summary>
    /// The normalized cost, with correctly-ordered and wrapped mana symbols.
    /// </summary>
    [JsonPropertyName("cost")]
    public string Cost { get; init; }

    /// <summary>
    /// The converted mana cost. If you submit Un-set mana symbols, this decimal could include fractional parts.
    /// </summary>
    [JsonPropertyName("cmc")]
    public decimal ConvertedManaCost { get; init; }

    /// <summary>
    /// The colors of the given cost.
    /// </summary>
    [JsonPropertyName("colors")]
    public IReadOnlyCollection<string> Colors { get; init; } = [];

    /// <summary>
    /// True if the cost is colorless.
    /// </summary>
    [JsonPropertyName("colorless")]
    public bool IsColorless { get; init; }

    /// <summary>
    /// True if the cost is monocolored.
    /// </summary>
    [JsonPropertyName("monocolored")]
    public bool IsMonocolored { get; init; }

    /// <summary>
    /// True if the cost is multicolored.
    /// </summary>
    [JsonPropertyName("multicolored")]
    public bool IsMulticolored { get; init; }
}
