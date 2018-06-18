using System;
using Newtonsoft.Json;

namespace ScryfallApi.Client.Models
{
    public class Symbol : BaseItem, IEquatable<string>, IComparable, IComparable<string>
    {
        /// <summary>
        /// The plaintext symbol. Often surrounded with curly braces {}. Note that not all symbols
        /// are ASCII text (for example, {∞}).
        /// </summary>
        [JsonProperty("symbol")]
        public string Text { get; set; }

        /// <summary>
        /// An alternate version of this symbol, if it is possible to write it without curly braces.
        /// </summary>
        [JsonProperty("loose_variant")]
        public string LooseVariant { get; set; }

        /// <summary>
        /// An English snippet that describes this symbol. Appropriate for use in alt text or other
        /// accessible communication formats.
        /// </summary>
        [JsonProperty("english")]
        public string Description { get; set; }

        /// <summary>
        /// True if it is possible to write this symbol “backwards”. For example, the official symbol
        /// {U/P} is sometimes written as {P/U} or {P\U} in informal settings. Note that the Scryfall
        /// API never writes symbols backwards in other responses. This field is provided for informational
        /// purposes.
        /// </summary>
        [JsonProperty("transposable")]
        public bool IsTransposable { get; set; }

        /// <summary>
        /// True if this is a mana symbol.
        /// </summary>
        [JsonProperty("represents_mana")]
        public bool IsManaSymbol { get; set; }

        /// <summary>
        /// A decimal number representing this symbol’s converted mana cost. Note that mana symbols from
        /// funny sets can have fractional converted mana costs.
        /// </summary>
        [JsonProperty("cmc")]
        public decimal? ConvertedManaCost { get; set; }

        /// <summary>
        /// True if this symbol appears in a mana cost on any Magic card. For example {20} has this field
        /// set to false because {20} only appears in Oracle text, not mana costs.
        /// </summary>
        [JsonProperty("appears_in_mana_costs")]
        public bool AppearsInManaCosts { get; set; }

        /// <summary>
        /// True if this symbol is only used on funny cards or Un-cards.
        /// </summary>
        [JsonProperty("funny")]
        public bool IsFunny { get; set; }

        /// <summary>
        /// An array of colors that this symbol represents.
        /// </summary>
        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        public int CompareTo(string other) => Text.CompareTo(other);
        public int CompareTo(object other) => CompareTo((other as Symbol)?.Text);
        public bool Equals(string other) => Text.Equals(other);
        public override string ToString() => Text;
    }
}