using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models
{
    public class ManaCost : BaseItem
    {
        /// <summary>
        /// The normalized cost, with correctly-ordered and wrapped mana symbols.
        /// </summary>
        [JsonPropertyName("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// The converted mana cost. If you submit Un-set mana symbols, this decimal could include fractional parts.
        /// </summary>
        [JsonPropertyName("cmc")]
        public decimal ConvertedManaCost { get; set; }

        /// <summary>
        /// The colors of the given cost.
        /// </summary>
        [JsonPropertyName("colors")]
        public string[] Colors { get; set; }

        /// <summary>
        /// True if the cost is colorless.
        /// </summary>
        [JsonPropertyName("colorless")]
        public bool IsColorless { get; set; }

        /// <summary>
        /// True if the cost is monocolored.
        /// </summary>
        [JsonPropertyName("monocolored")]
        public bool IsMonocolored { get; set; }

        /// <summary>
        /// True if the cost is multicolored.
        /// </summary>
        [JsonPropertyName("multicolored")]
        public bool IsMulticolored { get; set; }
    }
}