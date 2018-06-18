using Newtonsoft.Json;

namespace ScryfallApi.Client.Models
{
    public class CardFace : BaseItem
    {
        /// <summary>
        /// The name of this particular face.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The type line of this particular face.
        /// </summary>
        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }


        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }
    }
}