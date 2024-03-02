using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

/// <summary>
/// <para>Scryfall provides daily exports of our card data in bulk files. Each of these files is
/// represented as a bulk_data object via the API. URLs for files change their timestamp each day,
/// and can be fetched programmatically.</para>
/// <para>Please note:</para>
/// <para>Card objects in bulk data include price information, but prices should be considered
/// dangerously stale after 24 hours.Only use bulk price information to track trends or provide a
/// general estimate of card value.Prices are not updated frequently enough to power a storefront
/// or sales system. You consume price information at your own risk.</para>
/// <para>Updates to gameplay data (such as card names, Oracle text, mana costs, etc) are much less
/// frequent.If you only need gameplay information, downloading card data once per week or right
/// after set releases would most likely be sufficient.</para>
/// <para>Every card type in every product is included, including planar cards, schemes, Vanguard
/// cards, tokens, emblems, and funny cards.Make sure you’ve reviewed documentation for the Card
/// type.</para>
/// <para>Bulk data is only collected once every 12 hours.You can use the card API methods to
/// retrieve fresh objects instead.</para>
/// </summary>
public class BulkDataItem : BaseItem
{
    /// <summary>A unique ID for this bulk item.</summary>
    [JsonPropertyName("id")]
    public Guid Id { get; init; }

    /// <summary>The Scryfall API URI for this file.</summary>
    [JsonPropertyName("uri")]
    public Uri Uri { get; init; } = new Uri(ScryfallApiClientConfig.ScryfallApiAddress);

    /// <summary>A computer-readable string for the kind of bulk item.</summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = string.Empty;

    /// <summary>A human-readable name for this file.</summary>
    [JsonPropertyName("name")]
    public string Name { get; init; } = string.Empty;

    /// <summary>A human-readable description for this file.</summary>
    [JsonPropertyName("description")]
    public string Description { get; init; } = string.Empty;

    /// <summary>The URI that hosts this bulk file for fetching.</summary>
    [JsonPropertyName("download_uri")]
    public Uri DownloadUri { get; init; } = new Uri(ScryfallApiClientConfig.ScryfallApiAddress);

    /// <summary>The time when this file was last updated.</summary>
    [JsonPropertyName("updated_at")]
    public DateTimeOffset LastUpdated { get; init; }

    /// <summary>The size of this file in integer bytes.</summary>
    [JsonPropertyName("size")]
    public long FileSizeInBytes { get; init; }

    /// <summary>The MIME type of this file.</summary>
    [JsonPropertyName("content_type")]
    public string ContentType { get; init; } = string.Empty;

    /// <summary>The Content-Encoding encoding that will be used to transmit this file when you download it.</summary>
    [JsonPropertyName("content_encoding")]
    public string ContentEncoding { get; init; } = string.Empty;
}
