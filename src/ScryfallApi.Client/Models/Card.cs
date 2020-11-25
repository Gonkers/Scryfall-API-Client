using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace ScryfallApi.Client.Models
{
    /// <summary>
    /// Card objects represent individual Magic: The Gathering cards that players could obtain and
    /// add to their collection (with a few minor exceptions).
    /// </summary>
    public class Card : BaseItem
    {
        #region Core Fields

        /// <summary>
        /// A unique ID for this card in Scryfall’s database.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// This card’s multiverse IDs on Gatherer, if any, as an array of integers. Note that
        /// Scryfall includes many promo cards, tokens, and other esoteric objects that do not have
        /// these identifiers.
        /// </summary>
        [JsonPropertyName("multiverse_ids")]
        public int[] MultiverseIds { get; set; }

        /// <summary>
        /// This card’s Magic Online ID (also known as the Catalog ID), if any. A large percentage
        /// of cards are not available on Magic Online and do not have this ID
        /// </summary>
        [JsonPropertyName("mtgo_id")]
        public int MtgoId { get; set; }

        /// <summary>
        /// This card’s foil Magic Online ID (also known as the Catalog ID), if any. A large
        /// percentage of cards are not available on Magic Online and do not have this ID.
        /// </summary>
        [JsonPropertyName("mtgo_foil_id")]
        public int MtgoFoilId { get; set; }

        /// <summary>
        /// A link to this card object on Scryfall’s API.
        /// </summary>
        [JsonPropertyName("uri")]
        public Uri Uri { get; set; }

        /// <summary>
        /// A link to this card’s permapage on Scryfall’s website.
        /// </summary>
        [JsonPropertyName("scryfall_uri")]
        public Uri ScryfallUri { get; set; }

        /// <summary>
        /// A link to where you can begin paginating all re/prints for this card on Scryfall’s API.
        /// </summary>
        [JsonPropertyName("prints_search_uri")]
        public Uri PrintsSearchUri { get; set; }

        /// <summary>
        /// A link to this card’s rulings on Scryfall’s API.
        /// </summary>
        [JsonPropertyName("rulings_uri")]
        public Uri RulingsUri { get; set; }

        #endregion Core Fields

        #region Gameplay Fields

        /// <summary>
        /// The name of this card. If this card has multiple faces, this field will contain both
        /// names separated by ␣//␣.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// A computer-readable designation for this card’s layout. See the layout article.
        /// </summary>
        [JsonPropertyName("layout")]
        public string Layout { get; set; }

        /// <summary>
        /// The card’s converted mana cost. Note that some funny cards have fractional mana costs.
        /// </summary>
        [JsonPropertyName("cmc")]
        public decimal ConvertedManaCost { get; set; }

        /// <summary>
        /// The type line of this card.
        /// </summary>
        [JsonPropertyName("type_line")]
        public string TypeLine { get; set; }

        /// <summary>
        /// The Oracle text for this card, if any.
        /// </summary>
        [JsonPropertyName("oracle_text")]
        public string OracleText { get; set; }

        /// <summary>
        /// The mana cost for this card. This value will be any empty string "" if the cost is
        /// absent. Remember that per the game rules, a missing mana cost and a mana cost of {0} are
        /// different values.
        /// </summary>
        [JsonPropertyName("mana_cost")]
        public string ManaCost { get; set; }

        /// <summary>
        /// This card’s power, if any. Note that some cards have powers that are not numeric, such
        /// as *.
        /// </summary>
        [JsonPropertyName("power")]
        public string Power { get; set; }

        /// <summary>
        /// This card’s toughness, if any. Note that some cards have toughnesses that are not
        /// numeric, such as *.
        /// </summary>
        [JsonPropertyName("toughness")]
        public string Toughness { get; set; }

        /// <summary>
        /// This loyalty if any. Note that some cards have loyalties that are not numeric, such as X.
        /// </summary>
        [JsonPropertyName("loyalty")]
        public string Loyalty { get; set; }

        /// <summary>
        /// This card’s life modifier, if it is Vanguard card. This value will contain a delta, such
        /// as +2.
        /// </summary>
        [JsonPropertyName("life_modifier")]
        public string LifeModifier { get; set; }

        /// <summary>
        /// This card’s hand modifier, if it is Vanguard card.This value will contain a delta, such
        /// as -1.
        /// </summary>
        [JsonPropertyName("hand_modifier")]
        public string HandModifier { get; set; }

        /// <summary>
        /// This card’s colors.
        /// </summary>
        [JsonPropertyName("colors")]
        public string[] Colors { get; set; }

        /// <summary>
        /// The colors in this card’s color indicator, if any.A null value for this field indicates
        /// the card does not have one.
        /// </summary>
        [JsonPropertyName("color_indicator")]
        public string[] ColorIndicator { get; set; }

        /// <summary>
        /// This card’s color identity.
        /// </summary>
        [JsonPropertyName("color_identity")]
        public string[] ColorIdentity { get; set; }

        /// <summary>
        /// If this card is closely related to other cards, this property will be an array with.
        /// </summary>
        [JsonPropertyName("all_parts")]
        public dynamic[] AllParts { get; set; }

        /// <summary>
        /// An array of Card Face objects, if this card is multifaced.
        /// </summary>
        [JsonPropertyName("card_faces")]
        public CardFace[] CardFaces { get; set; }

        /// <summary>
        /// An object describing the legality of this card in different formats
        /// </summary>
        [JsonPropertyName("legalities")]
        public Dictionary<string, string> Legalities { get; set; }

        /// <summary>
        /// Indicates if this card is on the Reserved List.
        /// </summary>
        [JsonPropertyName("reserved")]
        public bool Reserved { get; set; }

        /// <summary>
        /// This card’s overall rank/popularity on EDHREC. Not all cards are ranked.
        /// </summary>
        [JsonPropertyName("edhrec_rank")]
        public int EdhrecRank { get; set; }

        #endregion Gameplay Fields

        #region Print Fields

        [JsonPropertyName("set")]
        public string Set { get; set; }

        [JsonPropertyName("set_name")]
        public string SetName { get; set; }

        [JsonPropertyName("collector_number")]
        public string CollectorNumber { get; set; }

        [JsonPropertyName("set_search_uri")]
        public Uri SetSearchUri { get; set; }

        [JsonPropertyName("scryfall_set_uri")]
        public Uri ScryfallSetUri { get; set; }

        [JsonPropertyName("image_uris")]
        public Dictionary<string, Uri> ImageUris { get; set; }

        [JsonPropertyName("highres_image")]
        public bool HasHighresImage { get; set; }

        [JsonPropertyName("reprint")]
        public bool Reprint { get; set; }

        [JsonPropertyName("digital")]
        public bool Digital { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("flavor_text")]
        public string FlavorText { get; set; }

        [JsonPropertyName("artist")]
        public string Artist { get; set; }

        [JsonPropertyName("illustration_id")]
        public Guid IllustrationId { get; set; }

        [JsonPropertyName("frame")]
        public string Frame { get; set; }

        [JsonPropertyName("full_art")]
        public bool FullArt { get; set; }

        [JsonPropertyName("watermark")]
        public string Watermark { get; set; }

        [JsonPropertyName("border_color")]
        public string BorderColor { get; set; }

        [JsonPropertyName("story_spotlight_number")]
        public int StorySpotlightNumber { get; set; }

        [JsonPropertyName("story_spotlight_uri")]
        public Uri StorySpotlightUri { get; set; }

        [JsonPropertyName("timeshifted")]
        public bool Timeshifted { get; set; }

        [JsonPropertyName("colorshifted")]
        public bool Colorshifted { get; set; }

        [JsonPropertyName("futureshifted")]
        public bool Futureshifted { get; set; }

        #endregion Print Fields

        #region Retail Fields

        [JsonPropertyName("prices")]
        public Price Price { get; set; }

        [JsonPropertyName("related_uris")]
        public Dictionary<string, Uri> RelatedUris { get; set; }

        [JsonPropertyName("purchase_uris")]
        public Dictionary<string, Uri> RetailerUris { get; set; }

        #endregion Retail Fields

        public override string ToString() => Name +
            (!string.IsNullOrWhiteSpace(ManaCost) ? $" ({ManaCost})" : "") +
            (!string.IsNullOrWhiteSpace(TypeLine) ? $" {TypeLine}" : "");
    }
}