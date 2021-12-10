using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

public abstract class BaseItem
{
    [JsonPropertyName("object")]
    public string ObjectType { get; set; }
}
