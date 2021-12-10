using System.Text.Json.Serialization;


namespace ScryfallApi.Client.Models;

/// <summary>
/// Card objects represent individual Magic: The Gathering cards that players could obtain and
/// add to their collection (with a few minor exceptions).
/// </summary>
public class Card : BaseItem
{

    /// <summary>
    /// If this card is closely related to other cards, this property will be an array with.
    /// </summary>
    [JsonPropertyName("all_parts")]
    public Dictionary<string, string>[] AllParts { get; set; }

    [JsonPropertyName("arena_id")]
    public int ArenaId { get; set; }

    [JsonPropertyName("artist_ids")]
    public string[] ArtistIds { get; set; }

    [JsonPropertyName("artist")]
    public string Artist { get; set; }

    [JsonPropertyName("booster")]
    public bool Booster { get; set; }

    [JsonPropertyName("border_color")]
    public string BorderColor { get; set; }

    [JsonPropertyName("card_back_id")]
    public string CardBackId { get; set; }

    /// <summary>
    /// An array of Card Face objects, if this card is multifaced.
    /// </summary>
    [JsonPropertyName("card_faces")]
    public CardFace[] CardFaces { get; set; }

    [JsonPropertyName("cardmarket_id")]
    public int CardMarketId { get; set; }

    /// <summary>
    /// The card’s converted mana cost, now known as mana value. Note that some funny cards have fractional mana costs.
    /// </summary>
    [JsonPropertyName("cmc")]
    public decimal Cmc { get; set; }

    [JsonPropertyName("collector_number")]
    public string CollectorNumber { get; set; }

    /// <summary>
    /// This card’s color identity.
    /// </summary>
    [JsonPropertyName("color_identity")]
    public string[] ColorIdentity { get; set; }

    /// <summary>
    /// The colors in this card’s color indicator, if any.A null value for this field indicates
    /// the card does not have one.
    /// </summary>
    [JsonPropertyName("color_indicator")]
    public string[] ColorIndicator { get; set; }

    /// <summary>
    /// This card’s colors.
    /// </summary>
    [JsonPropertyName("colors")]
    public string[] Colors { get; set; }

    [JsonPropertyName("content_warning")]
    public bool ContentWarning { get; set; }

    [JsonPropertyName("digital")]
    public bool Digital { get; set; }

    /// <summary>
    /// This card’s overall rank/popularity on EDHREC. Not all cards are ranked.
    /// </summary>
    [JsonPropertyName("edhrec_rank")]
    public int EdhrecRank { get; set; }

    [JsonPropertyName("finishes")]
    public string[] Finishes { get; set; }

    [JsonPropertyName("flavor_name")]
    public string FlavorName { get; set; }

    [JsonPropertyName("flavor_text")]
    public string FlavorText { get; set; }

    [JsonPropertyName("frame")]
    public string Frame { get; set; }

    [JsonPropertyName("frame_effects")]
    public string[] FrameEffects { get; set; }

    [JsonPropertyName("full_art")]
    public bool FullArt { get; set; }

    [JsonPropertyName("games")]
    public string[] Games { get; set; }

    /// <summary>
    /// This card’s hand modifier, if it is Vanguard card.This value will contain a delta, such as -1.
    /// </summary>
    [JsonPropertyName("hand_modifier")]
    public string HandModifier { get; set; }

    [JsonPropertyName("highres_image")]
    public bool HighresImage { get; set; }

    /// <summary>
    /// A unique ID for this card in Scryfall’s database.
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("illustration_id")]
    public Guid IllustrationId { get; set; }

    [JsonPropertyName("image_status")]
    public string ImageStatus { get; set; }

    [JsonPropertyName("image_uris")]
    public Dictionary<string, Uri> ImageUris { get; set; }

    [JsonPropertyName("keywords")]
    public string[] Keywords { get; set; }

    [JsonPropertyName("lang")]
    public string Language { get; set; }

    /// <summary>
    /// A computer-readable designation for this card’s layout. See the layout article.
    /// </summary>
    [JsonPropertyName("layout")]
    public string Layout { get; set; }

    /// <summary>
    /// An object describing the legality of this card in different formats
    /// </summary>
    [JsonPropertyName("legalities")]
    public Dictionary<string, string> Legalities { get; set; }

    /// <summary>
    /// This card’s life modifier, if it is Vanguard card. This value will contain a delta, such
    /// as +2.
    /// </summary>
    [JsonPropertyName("life_modifier")]
    public string LifeModifier { get; set; }

    /// <summary>
    /// This loyalty if any. Note that some cards have loyalties that are not numeric, such as X.
    /// </summary>
    [JsonPropertyName("loyalty")]
    public string Loyalty { get; set; }

    /// <summary>
    /// The mana cost for this card. This value will be any empty string "" if the cost is
    /// absent. Remember that per the game rules, a missing mana cost and a mana cost of {0} are
    /// different values.
    /// </summary>
    [JsonPropertyName("mana_cost")]
    public string ManaCost { get; set; }

    /// <summary>
    /// This card’s foil Magic Online ID (also known as the Catalog ID), if any. A large
    /// percentage of cards are not available on Magic Online and do not have this ID.
    /// </summary>
    [JsonPropertyName("mtgo_foil_id")]
    public int MtgoFoilId { get; set; }

    /// <summary>
    /// This card’s Magic Online ID (also known as the Catalog ID), if any. A large percentage
    /// of cards are not available on Magic Online and do not have this ID
    /// </summary>
    [JsonPropertyName("mtgo_id")]
    public int MtgoId { get; set; }

    /// <summary>
    /// This card’s multiverse IDs on Gatherer, if any, as an array of integers. Note that
    /// Scryfall includes many promo cards, tokens, and other esoteric objects that do not have
    /// these identifiers.
    /// </summary>
    [JsonPropertyName("multiverse_ids")]
    public int[] MultiverseIds { get; set; }
    /// <summary>
    /// The name of this card. If this card has multiple faces, this field will contain both
    /// names separated by ␣//␣.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("oracle_id")]
    public string OracleId { get; set; }

    /// <summary>
    /// The Oracle text for this card, if any.
    /// </summary>
    [JsonPropertyName("oracle_text")]
    public string OracleText { get; set; }

    [JsonPropertyName("oversized")]
    public bool Oversized { get; set; }

    /// <summary>
    /// This card’s power, if any. Note that some cards have powers that are not numeric, such
    /// as *.
    /// </summary>
    [JsonPropertyName("power")]
    public string Power { get; set; }

    [JsonPropertyName("preview")]
    public Dictionary<string, string> Prewiew { get; set; }

    [JsonPropertyName("prices")]
    public Price Prices { get; set; }

    [JsonPropertyName("printed_name")]
    public string PrintedName { get; set; }

    [JsonPropertyName("printed_text"]
    public string PrintedText { get; set; }

    [JsonPropertyName("printed_type_line"]
    public string PrintedTypeLine { get; set; }

    /// <summary>
    /// A link to where you can begin paginating all re/prints for this card on Scryfall’s API.
    /// </summary>
    [JsonPropertyName("prints_search_uri")]
    public Uri PrintsSearchUri { get; set; }

    [JsonPropertyName("produced_mana")]
    public string[] ProducedMana { get; set; }

    [JsonPropertyName("promo_types")]
    public string[] PromoTypes { get; set; }

    [JsonPropertyName("promo")]
    public bool Promo { get; set; }

    [JsonPropertyName("rarity")]
    public string Rarity { get; set; }

    [JsonPropertyName("related_uris")]
    public Dictionary<string, Uri> RelatedUris { get; set; }

    [JsonPropertyName("released_at")]
    public string ReleasedAt { get; set; }

    [JsonPropertyName("reprint")]
    public bool Reprint { get; set; }

    /// <summary>
    /// Indicates if this card is on the Reserved List.
    /// </summary>
    [JsonPropertyName("reserved")]
    public bool Reserved { get; set; }

    [JsonPropertyName("purchase_uris")]
    public Dictionary<string, Uri> RetailerUris { get; set; }

    /// <summary>
    /// A link to this card’s rulings on Scryfall’s API.
    /// </summary>
    [JsonPropertyName("rulings_uri")]
    public Uri RulingsUri { get; set; }

    [JsonPropertyName("scryfall_set_uri")]
    public Uri ScryfallSetUri { get; set; }

    /// <summary>
    /// A link to this card’s permapage on Scryfall’s website.
    /// </summary>
    [JsonPropertyName("scryfall_uri")]
    public Uri ScryfallUri { get; set; }

    [JsonPropertyName("security_stamp")]
    public string SecurityStamp { get; set; }

    [JsonPropertyName("set_id")]
    public string SetId { get; set; }

    [JsonPropertyName("set_name")]
    public string SetName { get; set; }

    [JsonPropertyName("set_search_uri")]
    public Uri SetSearchUri { get; set; }

    [JsonPropertyName("set_type")]
    public string SetType { get; set; }

    [JsonPropertyName("set_uri")]
    public string SetUri { get; set; }

    [JsonPropertyName("set")]
    public string Set { get; set; }

    [JsonPropertyName("story_spotlight")]
    public bool StorySpotlight { get; set; }

    [JsonPropertyName("tcgplayer_etched_id")]
    public int TcgplayerEtchedId { get; set; }

    [JsonPropertyName("tcgplayer_id")]
    public int TcgplayerId { get; set; }

    [JsonPropertyName("textless")]
    public bool Textless { get; set; }

    /// <summary>
    /// This card’s toughness, if any. Note that some cards have toughnesses that are not
    /// numeric, such as *.
    /// </summary>
    [JsonPropertyName("toughness")]
    public string Toughness { get; set; }

    /// <summary>
    /// The type line of this card.
    /// </summary>
    [JsonPropertyName("type_line")]
    public string TypeLine { get; set; }

    /// <summary>
    /// A link to this card object on Scryfall’s API.
    /// </summary>
    [JsonPropertyName("uri")]
    public Uri Uri { get; set; }

    [JsonPropertyName("variation_of")]
    public string VariationOf { get; set; }

    [JsonPropertyName("variation")]
    public bool Variation { get; set; }

    [JsonPropertyName("watermark")]
    public string Watermark { get; set; }
    public override string ToString() => Name +
        (!string.IsNullOrWhiteSpace(ManaCost) ? $" ({ManaCost})" : "") +
        (!string.IsNullOrWhiteSpace(TypeLine) ? $" {TypeLine}" : "");
}
