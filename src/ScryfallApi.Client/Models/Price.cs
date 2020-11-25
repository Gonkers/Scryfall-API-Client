using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models
{
    public class Price : BaseItem
    {
        [JsonConverter(typeof(DecimalAsStringConverter))]
        [JsonPropertyName("usd")]
        public decimal? Usd { get; set; }

        [JsonConverter(typeof(DecimalAsStringConverter))]
        [JsonPropertyName("usd_foil")]
        public decimal? UsdFoil { get; set; }

        [JsonConverter(typeof(DecimalAsStringConverter))]
        [JsonPropertyName("eur")]
        public decimal? Eur { get; set; }

        [JsonConverter(typeof(DecimalAsStringConverter))]
        [JsonPropertyName("eur_foil")]
        public decimal? EurFoil { get; set; }

        [JsonConverter(typeof(DecimalAsStringConverter))]
        [JsonPropertyName("tix")]
        public decimal? Tix { get; set; }
    }
}