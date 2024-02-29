using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

public class Price : BaseItem
{
    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("eur")]
    public decimal? Eur { get; init; }

    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("eur_foil")]
    public decimal? EurFoil { get; init; }

    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("tix")]
    public decimal? Tix { get; init; }

    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("usd")]
    public decimal? Usd { get; init; }

    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("usd_etched")]
    public decimal? UsdEtched { get; init; }

    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("usd_foil")]
    public decimal? UsdFoil { get; init; }
}
