using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace ScryfallApi.Client.Models
{
    public class CardFace : BaseItem
    {
        /// <summary>
        /// The name of this particular face.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The mana cost for this card. This value will be any empty string "" if the cost is
        /// absent. Remember that per the game rules, a missing mana cost and a mana cost of {0}
        /// are different values.
        /// </summary>
        [JsonPropertyName("mana_cost")]
        public string ManaCost { get; set; }

        /// <summary>
        /// The type line of this particular face.
        /// </summary>
        [JsonPropertyName("type_line")]
        public string TypeLine { get; set; }

        /// <summary>
        /// The Oracle text for this face, if any.
        /// </summary>
        [JsonPropertyName("oracle_text")]
        public string OracleText { get; set; }

        /// <summary>
        /// This face’s colors.
        /// </summary>
        [JsonPropertyName("colors")]
        public string[] Colors { get; set; }

        /// <summary>
        /// This card’s power, if any. Note that some cards have powers that are not numeric,
        /// such as *.
        /// </summary>
        [JsonPropertyName("power")]
        public string Power { get; set; }

        /// <summary>
        /// This card’s toughness, if any. Note that some cards have toughnesses that are not
        /// numeric, such as *.
        /// </summary>
        [JsonPropertyName("toughness")]
        public string Toughness { get; set; }

        [JsonPropertyName("flavor_text")]
        public string FlavorText { get; set; }

        [JsonPropertyName("artist")]
        public string Artist { get; set; }

        [JsonPropertyName("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonPropertyName("image_uris")]
        public Dictionary<string, Uri> ImageUris { get; set; }
    }
}