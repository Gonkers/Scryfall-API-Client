using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

class Catalog : BaseItem
{
    [JsonPropertyName("uri")]
    public Uri Uri { get; init; }

    [JsonPropertyName("total_values")]
    public int TotalValues { get; init; }

    [JsonPropertyName("data")]
    public IReadOnlyCollection<string> Data { get; init; } = [];
}
