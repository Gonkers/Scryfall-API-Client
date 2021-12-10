using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

public class Price : BaseItem
{
    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("usd")]
    public decimal? Usd { get; set; }

    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("usd_foil")]
    public decimal? UsdFoil { get; set; }

    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("usd_etched")]
    public decimal? UsdEtched { get; set; }

    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("eur")]
    public decimal? Eur { get; set; }

    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("eur_foil")]
    public decimal? EurFoil { get; set; }

    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("tix")]
    public decimal? Tix { get; set; }
}
