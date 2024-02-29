using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

/// <summary>
/// <para>A Set object represents a group of related Magic cards. All Card objects on Scryfall
/// belong to exactly one set.</para>
/// <para> Due to Magic’s long and complicated history, Scryfall includes many un-official sets
/// as a way to group promotional or outlier cards together.Such sets will likely have a
/// code that begins with p or t, such as pcel or tori.</para>
/// <para>Official sets always have a three-letter set code, such as zen.</para>
/// </summary>
public class Set : BaseItem
{
    /// <summary>
    /// A unique ID for this set on Scryfall that will not change.
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// The unique code for this set on Arena, which may differ from the regular code.
    /// </summary>
    [JsonPropertyName("arena_code")]
    public string? ArenaCode { get; init; }

    /// <summary>
    /// The block or group name code for this set, if any.
    /// </summary>
    [JsonPropertyName("block")]
    public string? Block { get; init; }

    /// <summary>
    /// The block code for this set, if any.
    /// </summary>
    [JsonPropertyName("block_code")]
    public string? BlockCode { get; init; }

    /// <summary>
    /// The number of cards in this set.
    /// </summary>
    [JsonPropertyName("card_count")]
    public int CardCount { get; init; }

    /// <summary>
    /// The unique three or four-letter code for this set.
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; init; } = string.Empty;

    /// <summary>
    /// A URI to an SVG file for this set’s icon on Scryfall’s CDN. Hotlinking this image isn’t
    /// recommended, because it may change slightly over time. You should download it and use it
    /// locally for your particular user interface needs.
    /// </summary>
    [JsonPropertyName("icon_svg_uri")]
    public Uri? IconSvgUri { get; init; }

    /// <summary>
    /// True if this set was only released on Magic Online.
    /// </summary>
    [JsonPropertyName("digital")]
    public bool IsDigital { get; init; }

    /// <summary>
    /// True if this set contains only nonfoil cards.
    /// </summary>
    [JsonPropertyName("nonfoil_only")]
    public bool NonfoilOnly { get; init; }

    /// <summary>
    /// True if this set contains only foil cards.
    /// </summary>
    [JsonPropertyName("foil_only")]
    public bool IsFoilOnly { get; init; }

    /// <summary>
    /// The unique code for this set on MTGO, which may differ from the regular code.
    /// </summary>
    [JsonPropertyName("mtgo_code")]
    public string? MtgoCode { get; init; }

    /// <summary>
    /// The English name of the set.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; } = string.Empty;

    /// <summary>
    /// The set code for the parent set, if any. promo and token sets often have a parent set.
    /// </summary>
    [JsonPropertyName("parent_set_code")]
    public string? ParentSetCode { get; init; }

    /// <summary>
    /// The denominator for the set’s printed collector numbers.
    /// </summary>
    [JsonPropertyName("printed_size")]
    public string? PrintedSize { get; init; }

    /// <summary>
    /// The date the set was released (in GMT-8 Pacific time). Not all sets have a known release date.
    /// </summary>
    [JsonPropertyName("released_at")]
    public DateOnly? ReleaseDate { get; init; }

    /// <summary>
    /// A link to this set’s permapage on Scryfall’s website.
    /// </summary>
    [JsonPropertyName("scryfall_uri")]
    public Uri? ScryfallUri { get; init; }

    /// <summary>
    /// A computer-readable classification for this set. See below.
    /// </summary>
    [JsonPropertyName("set_type")]
    public string SetType { get; init; } = string.Empty;

    /// <summary>
    /// A Scryfall API URI that you can request to begin paginating over the cards in this set.
    /// </summary>
    [JsonPropertyName("search_uri")]
    public Uri? SearchUri { get; init; }

    /// <summary>
    /// This set’s ID on TCGplayer’s API, also known as the groupId.
    /// </summary>
    [JsonPropertyName("tcgplayer_id")]
    public int? TcgPlayerId { get; init; }

    /// <summary>
    /// A link to this set object on Scryfall’s API.
    /// </summary>
    [JsonPropertyName("uri")]
    public Uri? Uri { get; init; }

    /// <summary>
    /// A human-readable description of this set’s type.
    /// </summary>
    public override string ToString() => $"{Name} ({Code})";
}
