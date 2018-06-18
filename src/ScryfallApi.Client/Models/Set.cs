using System;
using Newtonsoft.Json;

namespace ScryfallApi.Client.Models
{
    public class Set : BaseItem
    {
        /// <summary>
        /// The unique three or four-letter code for this set.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// The unique code for this set on MTGO, which may differ from the regular code.
        /// </summary>
        [JsonProperty("mtgo_code")]
        public string MtgoCode { get; set; }

        /// <summary>
        /// The English name of the set.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A computer-readable classification for this set. See below.
        /// </summary>
        [JsonProperty("set_type")]
        public string SetType { get; set; }

        /// <summary>
        /// The date the set was released (in GMT-8 Pacific time). Not all sets have a known release date.
        /// </summary>
        [JsonProperty("released_at")]
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// The block code for this set, if any.
        /// </summary>
        [JsonProperty("block_code")]
        public string BlockCode { get; set; }

        /// <summary>
        /// The block or group name code for this set, if any.
        /// </summary>
        [JsonProperty("block")]
        public string Block { get; set; }

        /// <summary>
        /// The set code for the parent set, if any. promo and token sets often have a parent set.
        /// </summary>
        [JsonProperty("parent_set_code")]
        public string ParentSetCode { get; set; }

        /// <summary>
        /// The number of cards in this set.
        /// </summary>
        [JsonProperty("card_count")]
        public int card_count { get; set; }

        /// <summary>
        /// True if this set was only released on Magic Online.
        /// </summary>
        [JsonProperty("digital")]
        public bool IsDigital { get; set; }

        /// <summary>
        /// True if this set contains only foil cards.
        /// </summary>
        [JsonProperty("foil_only")]
        public bool IsFoilOnly { get; set; }

        /// <summary>
        /// A URI to an SVG file for this set’s icon on Scryfall’s CDN. Hotlinking this image isn’t
        /// recommended, because it may change slightly over time. You should download it and use it
        /// locally for your particular user interface needs.
        /// </summary>
        [JsonProperty("icon_svg_uri")]
        public Uri IconSvgUri { get; set; }

        /// <summary>
        /// A Scryfall API URI that you can request to begin paginating over the cards in this set.
        /// </summary>
        [JsonProperty("search_uri")]
        public Uri SsearchUri { get; set; }

        public override string ToString() => $"{Name} ({Code})";
    }
}