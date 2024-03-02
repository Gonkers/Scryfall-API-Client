using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

/// <summary>
/// A collection of prices for this card on the Scryfall API.
/// </summary>
public class Price : BaseItem
{
    /// <summary>
    /// EUR price
    /// </summary>
    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("eur")]
    public decimal? Eur { get; init; }

    /// <summary>
    /// EUR price for foil cards
    /// </summary>
    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("eur_foil")]
    public decimal? EurFoil { get; init; }

    /// <summary>
    /// TIX price
    /// </summary>
    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("tix")]
    public decimal? Tix { get; init; }

    /// <summary>
    /// USD price
    /// </summary>
    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("usd")]
    public decimal? Usd { get; init; }

    /// <summary>
    /// USD price for etched cards
    /// </summary>
    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("usd_etched")]
    public decimal? UsdEtched { get; init; }

    /// <summary>
    /// USD price for foil cards
    /// </summary>
    [JsonConverter(typeof(UsDecimalAsStringConverter))]
    [JsonPropertyName("usd_foil")]
    public decimal? UsdFoil { get; init; }
}
