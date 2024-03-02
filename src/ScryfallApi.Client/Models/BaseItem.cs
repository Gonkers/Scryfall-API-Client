using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

/// <summary>
/// Base class for all Scryfall items.
/// </summary>
public abstract class BaseItem
{
    /// <summary>
    /// A content type for this object.
    /// </summary>
    [JsonPropertyName("object")]
    public string ObjectType { get; init; } = string.Empty;
}
