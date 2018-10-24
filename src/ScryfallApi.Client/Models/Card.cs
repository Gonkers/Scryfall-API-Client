using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ScryfallApi.Client.Models
{
    /// <summary>
    /// Card objects represent individual Magic: The Gathering cards that players could obtain
    /// and add to their collection (with a few minor exceptions).
    /// </summary>
    public class Card : BaseItem
    {
        #region Core Fields

        /// <summary>
        /// A unique ID for this card in Scryfall’s database.
        /// </summary>
        [JsonProperty("id")]
        public Guid Id { get; set; }

        /// <summary>
        /// This card’s multiverse IDs on Gatherer, if any, as an array of integers. Note that
        /// Scryfall includes many promo cards, tokens, and other esoteric objects that do not
        /// have these identifiers.
        /// </summary>
        [JsonProperty("multiverse_ids")]
        public int[] MultiverseIds { get; set; }

        /// <summary>
        /// This card’s Magic Online ID (also known as the Catalog ID), if any. A large
        /// percentage of cards are not available on Magic Online and do not have this ID
        /// </summary>
        [JsonProperty("mtgo_id")]
        public int MtgoId { get; set; }

        /// <summary>
        /// This card’s foil Magic Online ID (also known as the Catalog ID), if any. A large
        /// percentage of cards are not available on Magic Online and do not have this ID.
        /// </summary>
        [JsonProperty("mtgo_foil_id")]
        public int MtgoFoilId { get; set; }

        /// <summary>
        /// A link to this card object on Scryfall’s API.
        /// </summary>
        [JsonProperty("uri")]
        public Uri Uri { get; set; }

        /// <summary>
        /// A link to this card’s permapage on Scryfall’s website.
        /// </summary>
        [JsonProperty("scryfall_uri")]
        public Uri ScryfallUri { get; set; }

        /// <summary>
        /// A link to where you can begin paginating all re/prints for this card on
        /// Scryfall’s API.
        /// </summary>
        [JsonProperty("prints_search_uri")]
        public Uri PrintsSearchUri { get; set; }

        /// <summary>
        /// A link to this card’s rulings on Scryfall’s API.
        /// </summary>
        [JsonProperty("rulings_uri")]
        public Uri RulingsUri { get; set; }

        #endregion


        #region Gameplay Fields

        /// <summary>
        /// The name of this card. If this card has multiple faces, this field will contain both
        /// names separated by ␣//␣.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A computer-readable designation for this card’s layout. See the layout article.
        /// </summary>
        [JsonProperty("layout")]
        public string Layout { get; set; }

        /// <summary>
        /// The card’s converted mana cost. Note that some funny cards have fractional mana costs.
        /// </summary>
        [JsonProperty("cmc")]
        public decimal ConvertedManaCost { get; set; }

        /// <summary>
        /// The type line of this card.
        /// </summary>
        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        /// <summary>
        /// The Oracle text for this card, if any.
        /// </summary>
        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        /// <summary>
        /// The mana cost for this card. This value will be any empty string "" if the cost is
        /// absent. Remember that per the game rules, a missing mana cost and a mana cost of {0}
        /// are different values.
        /// </summary>
        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        /// <summary>
        /// This card’s power, if any. Note that some cards have powers that are not numeric,
        /// such as *.
        /// </summary>
        [JsonProperty("power")]
        public string Power { get; set; }

        /// <summary>
        /// This card’s toughness, if any. Note that some cards have toughnesses that are not
        /// numeric, such as *.
        /// </summary>
        [JsonProperty("toughness")]
        public string Toughness { get; set; }

        /// <summary>
        /// This loyalty if any. Note that some cards have loyalties that are not numeric,
        /// such as X.
        /// </summary>
        [JsonProperty("loyalty")]
        public string Loyalty { get; set; }

        /// <summary>
        /// This card’s life modifier, if it is Vanguard card. This value will contain a
        /// delta, such as +2.
        /// </summary>
        [JsonProperty("life_modifier")]
        public string LifeModifier { get; set; }

        /// <summary>
        /// This card’s hand modifier, if it is Vanguard card.This value will contain a
        /// delta, such as -1.
        /// </summary>
        [JsonProperty("hand_modifier")]
        public string HandModifier { get; set; }

        /// <summary>
        /// This card’s colors.
        /// </summary>
        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        /// <summary>
        /// The colors in this card’s color indicator, if any.A null value for this field
        /// indicates the card does not have one.
        /// </summary>
        [JsonProperty("color_indicator")]
        public string[] ColorIndicator { get; set; }

        /// <summary>
        /// This card’s color identity.
        /// </summary>
        [JsonProperty("color_identity")]
        public string[] ColorIdentity { get; set; }

        /// <summary>
        /// If this card is closely related to other cards, this property will be an
        /// array with.
        /// </summary>
        [JsonProperty("all_parts")]
        public dynamic[] AllParts { get; set; }

        /// <summary>
        /// An array of Card Face objects, if this card is multifaced.
        /// </summary>
        [JsonProperty("card_faces")]
        public CardFace[] CardFaces { get; set; }

        /// <summary>
        /// An object describing the legality of this card in different formats
        /// </summary>
        [JsonProperty("legalities")]
        public Dictionary<string, string> Legalities { get; set; }

        /// <summary>
        /// Indicates if this card is on the Reserved List.
        /// </summary>
        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        /// <summary>
        /// This card’s overall rank/popularity on EDHREC. Not all cards are ranked.
        /// </summary>
        [JsonProperty("edhrec_rank")]
        public int EdhrecRank { get; set; }

        #endregion


        #region Print Fields

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("collector_number")]
        public string CollectorNumber { get; set; }

        [JsonProperty("set_search_uri")]
        public Uri SetSearchUri { get; set; }

        [JsonProperty("scryfall_set_uri")]
        public Uri ScryfallSetUri { get; set; }

        [JsonProperty("image_uris")]
        public Dictionary<string, Uri> ImageUris { get; set; }

        [JsonProperty("highres_image")]
        public bool HasHighresImage { get; set; }

        [JsonProperty("reprint")]
        public bool Reprint { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("illustration_id")]
        public Guid IllustrationId { get; set; }

        [JsonProperty("frame")]
        public string Frame { get; set; }

        [JsonProperty("full_art")]
        public bool FullArt { get; set; }

        [JsonProperty("watermark")]
        public string Watermark { get; set; }

        [JsonProperty("border_color")]
        public string BorderColor { get; set; }

        [JsonProperty("story_spotlight_number")]
        public int StorySpotlightNumber { get; set; }

        [JsonProperty("story_spotlight_uri")]
        public Uri StorySpotlightUri { get; set; }

        [JsonProperty("timeshifted")]
        public bool Timeshifted { get; set; }

        [JsonProperty("colorshifted")]
        public bool Colorshifted { get; set; }

        [JsonProperty("futureshifted")]
        public bool Futureshifted { get; set; }

        #endregion


        #region Retail Fields

        [JsonProperty("usd")]
        public string Usd { get; set; }

        [JsonProperty("eur")]
        public string Eur { get; set; }

        [JsonProperty("related_uris")]
        public Dictionary<string, Uri> RelatedUris { get; set; }

        [JsonProperty("purchase_uris")]
        public Dictionary<string, Uri> RetailerUris { get; set; }

        #endregion


        public override string ToString() => Name +
            (!string.IsNullOrWhiteSpace(ManaCost) ? $" ({ManaCost})" : "") +
            (!string.IsNullOrWhiteSpace(TypeLine) ? $" {TypeLine}" : "");
    }
}