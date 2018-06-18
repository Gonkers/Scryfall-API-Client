using Newtonsoft.Json;

namespace ScryfallApi.Client.Models
{
    public class ManaCost : BaseItem
    {
        /// <summary>
        /// The normalized cost, with correctly-ordered and wrapped mana symbols.
        /// </summary>
        [JsonProperty("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// The converted mana cost. If you submit Un-set mana symbols, this decimal could include fractional parts.
        /// </summary>
        [JsonProperty("cmc")]
        public decimal ConvertedManaCost { get; set; }

        /// <summary>
        /// The colors of the given cost.
        /// </summary>
        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        /// <summary>
        /// True if the cost is colorless.
        /// </summary>
        [JsonProperty("colorless")]
        public bool IsColorless { get; set; }

        /// <summary>
        /// True if the cost is monocolored.
        /// </summary>
        [JsonProperty("monocolored")]
        public bool IsMonocolored { get; set; }

        /// <summary>
        /// True if the cost is multicolored.
        /// </summary>
        [JsonProperty("multicolored")]
        public bool IsMulticolored { get; set; }
    }
}