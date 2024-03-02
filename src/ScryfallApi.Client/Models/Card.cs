using System.Text.Json.Serialization;


namespace ScryfallApi.Client.Models;

/// <summary>
/// Card objects represent individual Magic: The Gathering cards that players could obtain and
/// add to their collection (with a few minor exceptions).
/// </summary>
public class Card : BaseItem
{
    // Cards have the following core properties:
    #region Core Card Fields

    /// <summary>
    /// This card’s Arena ID, if any. A large percentage of cards are not available on Arena and do not have this ID.
    /// </summary>
    [JsonPropertyName("arena_id")]
    public int? ArenaId { get; init; }

    /// <summary>
    /// A unique ID for this card in Scryfall’s database.
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; init; }

    /// <summary>
    /// A language code for this printing.
    /// </summary>
    [JsonPropertyName("lang")]
    public string Language { get; init; } = string.Empty;

    /// <summary>
    /// This card’s Magic Online ID (also known as the Catalog ID), if any. A large percentage of cards are not available on Magic Online and do not have this ID.
    /// </summary>
    [JsonPropertyName("mtgo_id")]
    public int? MtgoId { get; init; }

    /// <summary>
    /// This card’s foil Magic Online ID (also known as the Catalog ID), if any. A large percentage of cards are not available on Magic Online and do not have this ID.
    /// </summary>
    [JsonPropertyName("mtgo_foil_id")]
    public int? MtgoFoilId { get; init; }

    /// <summary>
    /// This card’s multiverse IDs on Gatherer, if any, as an array of integers. Note that Scryfall includes many promo cards, tokens, and other esoteric objects that do not have these identifiers.
    /// </summary>
    [JsonPropertyName("multiverse_ids")]
    public IReadOnlyCollection<int> MultiverseIds { get; init; } = [];

    /// <summary>
    /// This card’s ID on TCGplayer’s API, also known as the productId.
    /// </summary>
    [JsonPropertyName("tcgplayer_id")]
    public int? TcgplayerId { get; init; }

    /// <summary>
    /// This card’s ID on TCGplayer’s API, for its etched version if that version is a separate product.
    /// </summary>
    [JsonPropertyName("tcgplayer_etched_id")]
    public int? TcgplayerEtchedId { get; init; }

    /// <summary>
    /// This card’s ID on Cardmarket’s API, also known as the idProduct.
    /// </summary>
    [JsonPropertyName("cardmarket_id")]
    public int? CardMarketId { get; init; }

    /// <summary>
    /// A code for this card’s layout.
    /// </summary>
    [JsonPropertyName("layout")]
    public string Layout { get; init; } = string.Empty;

    /// <summary>
    /// A unique ID for this card’s oracle identity. This value is consistent across reprinted card editions, and unique among different cards with the same name (tokens, Unstable variants, etc). Always present except for the reversible_card layout where it will be absent; oracle_id will be found on each face instead.
    /// </summary>
    [JsonPropertyName("oracle_id")]
    public Guid? OracleId { get; init; }

    /// <summary>
    /// A link to where you can begin paginating all re/prints for this card on Scryfall’s API.
    /// </summary>
    [JsonPropertyName("prints_search_uri")]
    public Uri PrintsSearchUri { get; init; } = new(ScryfallApiClientConfig.ScryfallApiAddress);

    /// <summary>
    /// A link to this card’s rulings list on Scryfall’s API.
    /// </summary>
    [JsonPropertyName("rulings_uri")]
    public Uri RulingsUri { get; init; } = new(ScryfallApiClientConfig.ScryfallApiAddress);

    /// <summary>
    /// A link to this card’s permapage on Scryfall’s website.
    /// </summary>
    [JsonPropertyName("scryfall_uri")]
    public Uri ScryfallUri { get; init; } = new(ScryfallApiClientConfig.ScryfallApiAddress);

    /// <summary>
    /// A link to this card object on Scryfall’s API.
    /// </summary>
    [JsonPropertyName("uri")]
    public Uri Uri { get; init; } = new(ScryfallApiClientConfig.ScryfallApiAddress);

    #endregion

    // Cards have the following properties relevant to the game rules:
    #region Gameplay Fields

    /// <summary>
    /// If this card is closely related to other cards, this property will be an array with.
    /// </summary>
    [JsonPropertyName("all_parts")]
    public IReadOnlyCollection<Dictionary<string, string>> AllParts { get; init; } = [];

    /// <summary>
    /// An array of Card Face objects, if this card is multifaced.
    /// </summary>
    [JsonPropertyName("card_faces")]
    public IReadOnlyCollection<CardFace> CardFaces { get; init; } = [];

    /// <summary>
    /// The card’s converted mana cost, now known as mana value. Note that some funny cards have fractional mana costs.
    /// </summary>
    [JsonPropertyName("cmc")]
    public decimal ManaValue { get; init; }

    /// <summary>
    /// This card’s color identity.
    /// </summary>
    [JsonPropertyName("color_identity")]
    public IReadOnlyCollection<string> ColorIdentity { get; init; } = [];

    /// <summary>
    /// The colors in this card’s color indicator, if any.A null value for this field indicates
    /// the card does not have one.
    /// </summary>
    [JsonPropertyName("color_indicator")]
    public IReadOnlyCollection<string> ColorIndicator { get; init; } = [];

    /// <summary>
    /// This card’s colors.
    /// </summary>
    [JsonPropertyName("colors")]
    public IReadOnlyCollection<string> Colors { get; init; } = [];

    /// <summary>
    ///  This face’s defense, if any.
    /// </summary>
    [JsonPropertyName("defense")]
    public string? Defense { get; init; }

    /// <summary>
    ///  This card’s overall rank/popularity on EDHREC. Not all cards are ranked.
    /// </summary>
    [JsonPropertyName("edhrec_rank")]
    public int? EdhrecRank { get; init; }

    /// <summary>
    ///  This card’s hand modifier, if it is Vanguard card. This value will contain a delta, such as -1.
    /// </summary>
    [JsonPropertyName("hand_modifier")]
    public string? HandModifier { get; init; }

    /// <summary>
    /// An array of keywords that this card uses, such as 'Flying' and 'Cumulative upkeep'.
    /// </summary>
    [JsonPropertyName("keywords")]
    public IReadOnlyCollection<string> Keywords { get; init; } = [];

    /// <summary>
    /// An object describing the legality of this card across play formats. Possible legalities are legal, not_legal, restricted, and banned.
    /// </summary>
    [JsonPropertyName("legalities")]
    public Dictionary<string, string> Legalities { get; init; } = [];

    /// <summary>
    ///  This card’s life modifier, if it is Vanguard card. This value will contain a delta, such as +2.
    /// </summary>
    [JsonPropertyName("life_modifier")]
    public string? LifeModifier { get; init; }

    /// <summary>
    ///  This loyalty if any. Note that some cards have loyalties that are not numeric, such as X.
    /// </summary>
    [JsonPropertyName("loyalty")]
    public string? Loyalty { get; init; }

    /// <summary>
    ///  The mana cost for this card. This value will be any empty string "" if the cost is absent. Remember that per the game rules, a missing mana cost and a mana cost of {0} are different values. Multi-faced cards will report this value in card faces.
    /// </summary>
    [JsonPropertyName("mana_cost")]
    public string? ManaCost { get; init; }

    /// <summary>
    /// The name of this card. If this card has multiple faces, this field will contain both names separated by ␣//␣.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; } = string.Empty;

    /// <summary>
    ///  The Oracle text for this card, if any.
    /// </summary>
    [JsonPropertyName("oracle_text")]
    public string? OracleText { get; init; }

    /// <summary>
    ///  This card’s rank/popularity on Penny Dreadful. Not all cards are ranked.
    /// </summary>
    [JsonPropertyName("penny_rank")]
    public int? PennyRank { get; init; }

    /// <summary>
    ///  This card’s power, if any. Note that some cards have powers that are not numeric, such as *.
    /// </summary>
    [JsonPropertyName("power")]
    public string? Power { get; init; }

    /// <summary>
    ///  Colors of mana that this card could produce.
    /// </summary>
    [JsonPropertyName("produced_mana")]
    public IReadOnlyCollection<string>? ProducedMana { get; init; } = [];

    /// <summary>
    /// True if this card is on the Reserved List.
    /// </summary>
    [JsonPropertyName("reserved")]
    public bool Reserved { get; init; }

    /// <summary>
    ///  This card’s toughness, if any. Note that some cards have toughnesses that are not numeric, such as *.
    /// </summary>
    [JsonPropertyName("toughness")]
    public string? Toughness { get; init; }

    /// <summary>
    /// The type line of this card.
    /// </summary>
    [JsonPropertyName("type_line")]
    public string TypeLine { get; init; } = string.Empty;

    #endregion

    // Cards have the following properties unique to their particular re/print:
    #region Print Fields

    /// <summary>
    /// The name of the illustrator of this card. Newly spoiled cards may not have this field yet.
    /// </summary>
    [JsonPropertyName("artist")]
    public string? Artist { get; init; }

    /// <summary>
    /// The IDs of the artists that illustrated this card. Newly spoiled cards may not have this field yet.
    /// </summary>
    [JsonPropertyName("artist_ids")]
    public IReadOnlyCollection<Guid> ArtistIds { get; init; } = [];

    /// <summary>
    /// The lit Unfinity attractions lights on this card, if any.
    /// </summary>
    [JsonPropertyName("attraction_lights")]
    public IReadOnlyCollection<int> AttractionLights { get; init; } = [];

    /// <summary>
    /// Whether this card is found in boosters.
    /// </summary>
    [JsonPropertyName("booster")]
    public bool Booster { get; init; }

    /// <summary>
    /// This card’s border color: black, white, borderless, silver, or gold.
    /// </summary>
    [JsonPropertyName("border_color")]
    public string BorderColor { get; init; } = string.Empty;

    /// <summary>
    /// The Scryfall ID for the card back design present on this card.
    /// </summary>
    [JsonPropertyName("card_back_id")]
    public Guid CardBackId { get; init; }

    /// <summary>
    /// This card’s collector number. Note that collector numbers can contain non-numeric characters, such as letters or ★.
    /// </summary>
    [JsonPropertyName("collector_number")]
    public string CollectorNumber { get; init; } = string.Empty;

    /// <summary>
    /// True if you should consider avoiding use of this print downstream.
    /// </summary>
    [JsonPropertyName("content_warning")]
    public bool? ContentWarning { get; init; }

    /// <summary>
    /// True if this card was only released in a video game.
    /// </summary>
    [JsonPropertyName("digital")]
    public bool Digital { get; init; }

    /// <summary>
    /// An array of computer-readable flags that indicate if this card can come in foil, nonfoil, or etched finishes.
    /// </summary>
    [JsonPropertyName("finishes")]
    public IReadOnlyCollection<string> Finishes { get; init; } = [];

    /// <summary>
    /// The just-for-fun name printed on the card (such as for Godzilla series cards).
    /// </summary>
    [JsonPropertyName("flavor_name")]
    public string? FlavorName { get; init; }

    /// <summary>
    /// The flavor text, if any.
    /// </summary>
    [JsonPropertyName("flavor_text")]
    public string? FlavorText { get; init; }

    /// <summary>
    /// This card’s frame effects, if any.
    /// </summary>
    [JsonPropertyName("frame_effects")]
    public IReadOnlyCollection<string> FrameEffects { get; init; } = [];

    /// <summary>
    /// This card’s frame layout.
    /// </summary>
    [JsonPropertyName("frame")]
    public string Frame { get; init; } = string.Empty;

    /// <summary>
    /// True if this card’s artwork is larger than normal.
    /// </summary>
    [JsonPropertyName("full_art")]
    public bool FullArt { get; init; }

    /// <summary>
    /// A list of games that this card print is available in, paper, arena, and/or mtgo.
    /// </summary>
    [JsonPropertyName("games")]
    public IReadOnlyCollection<string> Games { get; init; } = [];

    /// <summary>
    /// True if this card’s imagery is high resolution.
    /// </summary>
    [JsonPropertyName("highres_image")]
    public bool HighresImage { get; init; }

    /// <summary>
    /// A unique identifier for the card artwork that remains consistent across reprints. Newly spoiled cards may not have this field yet.
    /// </summary>
    [JsonPropertyName("illustration_id")]
    public Guid? IllustrationId { get; init; }

    /// <summary>
    /// A computer-readable indicator for the state of this card’s image, one of missing, placeholder, lowres, or highres_scan.
    /// </summary>
    [JsonPropertyName("image_status")]
    public string ImageStatus { get; init; } = string.Empty;

    /// <summary>
    /// An object listing available imagery for this card. See the Card Imagery article for more information.
    /// </summary>
    [JsonPropertyName("image_uris")]
    public Dictionary<string, Uri> ImageUris { get; init; } = [];

    /// <summary>
    /// True if this card is oversized.
    /// </summary>
    [JsonPropertyName("oversized")]
    public bool Oversized { get; init; }

    /// <summary>
    /// An object containing daily price information for this card, including usd, usd_foil, usd_etched, eur, eur_foil, eur_etched, and tix prices, as strings.
    /// </summary>
    [JsonPropertyName("prices")]
    public Price Prices { get; init; } = new Price();

    /// <summary>
    /// The localized name printed on this card, if any.
    /// </summary>
    [JsonPropertyName("printed_name")]
    public string? PrintedName { get; init; }

    /// <summary>
    /// The localized text printed on this card, if any.
    /// </summary>
    [JsonPropertyName("printed_text")]
    public string? PrintedText { get; init; }

    /// <summary>
    /// The localized type line printed on this card, if any.
    /// </summary>
    [JsonPropertyName("printed_type_line")]
    public string? PrintedTypeLine { get; init; }

    /// <summary>
    /// True if this card is a promotional print.
    /// </summary>
    [JsonPropertyName("promo")]
    public bool Promo { get; init; }

    /// <summary>
    /// An array of strings describing what categories of promo cards this card falls into.
    /// </summary>
    [JsonPropertyName("promo_types")]
    public IReadOnlyCollection<string> PromoTypes { get; init; } = [];

    /// <summary>
    /// An object providing URIs to this card’s listing on major marketplaces. Omitted if the card is unpurchaseable.
    /// </summary>
    [JsonPropertyName("purchase_uris")]
    public Dictionary<string, Uri> PurchaseUris { get; init; } = [];

    /// <summary>
    /// This card’s rarity. One of common, uncommon, rare, special, mythic, or bonus.
    /// </summary>
    [JsonPropertyName("rarity")]
    public string Rarity { get; init; } = string.Empty;

    /// <summary>
    /// An object providing URIs to this card’s listing on other Magic: The Gathering online resources.
    /// </summary>
    [JsonPropertyName("related_uris")]
    public Dictionary<string, Uri> RelatedUris { get; init; } = [];

    /// <summary>
    /// The date this card was first released.
    /// </summary>
    [JsonPropertyName("released_at")]
    public DateOnly ReleasedAt { get; init; }

    /// <summary>
    /// True if this card is a reprint.
    /// </summary>
    [JsonPropertyName("reprint")]
    public bool Reprint { get; init; }

    /// <summary>
    /// A link to this card’s set on Scryfall’s website.
    /// </summary>
    [JsonPropertyName("scryfall_set_uri")]
    public Uri ScryfallSetUri { get; init; } = new(ScryfallApiClientConfig.ScryfallApiAddress);

    /// <summary>
    /// This card’s full set name.
    /// </summary>
    [JsonPropertyName("set_name")]
    public string SetName { get; init; } = string.Empty;

    /// <summary>
    /// A link to where you can begin paginating this card’s set on the Scryfall API.
    /// </summary>
    [JsonPropertyName("set_search_uri")]
    public Uri SetSearchUri { get; init; } = new(ScryfallApiClientConfig.ScryfallApiAddress);

    /// <summary>
    /// The type of set this printing is in.
    /// </summary>
    [JsonPropertyName("set_type")]
    public string SetType { get; init; } = string.Empty;

    /// <summary>
    /// A link to this card’s set object on Scryfall’s API.
    /// </summary>
    [JsonPropertyName("set_uri")]
    public Uri SetUri { get; init; } = new(ScryfallApiClientConfig.ScryfallApiAddress);

    /// <summary>
    /// This card’s set code.
    /// </summary>
    [JsonPropertyName("set")]
    public string Set { get; init; } = string.Empty;

    /// <summary>
    /// This card’s Set object UUID.
    /// </summary>
    [JsonPropertyName("set_id")]
    public Guid SetId { get; init; }

    /// <summary>
    /// True if this card is a Story Spotlight.
    /// </summary>
    [JsonPropertyName("story_spotlight")]
    public bool StorySpotlight { get; init; }

    /// <summary>
    /// True if the card is printed without text.
    /// </summary>
    [JsonPropertyName("textless")]
    public bool Textless { get; init; }

    /// <summary>
    /// Whether this card is a variation of another printing.
    /// </summary>
    [JsonPropertyName("variation")]
    public bool Variation { get; init; }

    /// <summary>
    /// The printing ID of the printing this card is a variation of.
    /// </summary>
    [JsonPropertyName("variation_of")]
    public Guid? VariationOf { get; init; }

    /// <summary>
    /// The security stamp on this card, if any. One of oval, triangle, acorn, circle, arena, or heart.
    /// </summary>
    [JsonPropertyName("security_stamp")]
    public string? SecurityStamp { get; init; }

    /// <summary>
    /// This card’s watermark, if any.
    /// </summary>
    [JsonPropertyName("watermark")]
    public string? Watermark { get; init; }

    /// <summary>
    /// source - The name of the source that previewed this card.
    /// source_uri - A link to the preview for this card.
    /// previewed_at - The date this card was previewed.
    /// </summary>
    [JsonPropertyName("preview")]
    public Dictionary<string, string> Prewiew { get; init; } = [];

    #endregion

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns></returns>
    public override string ToString() => Name +
        (!string.IsNullOrWhiteSpace(ManaCost) ? $" ({ManaCost})" : "") +
        (!string.IsNullOrWhiteSpace(TypeLine) ? $" {TypeLine}" : "");
}
