using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

/// <summary>
/// Multiface cards have a card_faces property containing at least two Card Face objects.
/// </summary>
public class CardFace : BaseItem
{
    /// <summary>
    /// The name of the illustrator of this card face. Newly spoiled cards may not have this field yet.
    /// </summary>
    [JsonPropertyName("artist")]
    public string? Artist { get; init; }

    /// <summary>
    /// The ID of the illustrator of this card face. Newly spoiled cards may not have this field yet.
    /// </summary>
    [JsonPropertyName("artist_id")]
    public string? ArtistId { get; init; }

    /// <summary>
    /// The mana value of this particular face, if the card is reversible.
    /// </summary>
    [JsonPropertyName("cmc")]
    public decimal? ManaValue { get; init; }

    /// <summary>
    /// The color indicator for this face, if any.
    /// </summary>
    [JsonPropertyName("color_indicator")]
    public IReadOnlyCollection<string> ColorIndicator { get; init; } = [];

    /// <summary>
    /// This face’s colors, if the game defines colors for the individual face of this card.
    /// </summary>
    [JsonPropertyName("colors")]
    public IReadOnlyCollection<string> Colors { get; init; } = [];

    /// <summary>
    /// This face’s defense, if the game defines colors for the individual face of this card.
    /// </summary>
    [JsonPropertyName("defense")]
    public string? Defense { get; init; }

    /// <summary>
    /// Unknown property. This was a property that had shown up but is not documented.
    /// </summary>
    [JsonPropertyName("flavor_name"), Obsolete("This was a property that had shown up but is not documented.")]
    public string? FlavorName { get; init; }

    /// <summary>
    /// The flavor text printed on this face, if any.
    /// </summary>
    [JsonPropertyName("flavor_text")]
    public string? FlavorText { get; init; }

    /// <summary>
    /// A unique identifier for the card face artwork that remains consistent across reprints. Newly
    /// spoiled cards may not have this field yet.
    /// </summary>
    [JsonPropertyName("illustration_id")]
    public Guid? IllustrationId { get; init; }

    /// <summary>
    /// An object providing URIs to imagery for this face, if this is a double-sided card. If this card
    /// is not double-sided, then the image_uris property will be part of the parent object instead.
    /// </summary>
    [JsonPropertyName("image_uris")]
    public Dictionary<string, Uri>? ImageUris { get; init; }

    /// <summary>
    /// The layout of this card face, if the card is reversible.
    /// </summary>
    [JsonPropertyName("layout")]
    public string? Layout { get; init; }

    /// <summary>
    /// The loyalty of this card, if any.
    /// </summary>
    [JsonPropertyName("loyalty")]
    public string? Loyalty { get; init; }

    /// <summary>
    /// The mana cost for this face. This value will be any empty string "" if the cost is absent.
    /// Remember that per the game rules, a missing mana cost and a mana cost of {0} are different
    /// values.
    /// </summary>
    [JsonPropertyName("mana_cost")]
    public string ManaCost { get; init; } = string.Empty;

    /// <summary>
    /// The name of this particular face.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; } = string.Empty;

    /// <summary>
    /// The Oracle ID of this particular face, if the card is reversible.
    /// </summary>
    [JsonPropertyName("oracle_id")]
    public string? OracleId { get; init; }

    /// <summary>
    /// The Oracle text for this face, if any.
    /// </summary>
    [JsonPropertyName("oracle_text")]
    public string? OracleText { get; init; }

    /// <summary>
    /// This face’s power, if any. Note that some cards have powers that are not numeric,
    /// such as *.
    /// </summary>
    [JsonPropertyName("power")]
    public string? Power { get; init; }

    /// <summary>
    /// The localized name printed on this face, if any.
    /// </summary>
    [JsonPropertyName("printed_name")]
    public string? PrintedName { get; init; }

    /// <summary>
    /// The localized text printed on this face, if any.
    /// </summary>
    [JsonPropertyName("printed_text")]
    public string? PrintedText { get; init; }

    /// <summary>
    /// The localized type line printed on this face, if any.
    /// </summary>
    [JsonPropertyName("printed_type_line")]
    public string? PrintedTypeLine { get; init; }

    /// <summary>
    /// This card’s toughness, if any. Note that some cards have toughnesses that are not
    /// numeric, such as *.
    /// </summary>
    [JsonPropertyName("toughness")]
    public string Toughness { get; init; }

    /// <summary>
    /// The type line of this particular face, if the card is reversible.
    /// </summary>
    [JsonPropertyName("type_line")]
    public string? TypeLine { get; init; }

    /// <summary>
    /// The watermark on this particulary card face, if any.
    /// </summary>
    [JsonPropertyName("watermark")]
    public string? Watermark { get; init; }
}
