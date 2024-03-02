using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

/// <summary>
/// A List object represents a requested sequence of other objects (Cards, Sets, etc). List
/// objects may be paginated, and also include information about issues raised when generating
/// the list.
/// </summary>
/// <typeparam name="T"></typeparam>
public class ResultList<T> : BaseItem where T : BaseItem
{
    /// <summary>
    /// An array of the requested objects, in a specific order.
    /// </summary>
    [JsonPropertyName("data")]
    public IReadOnlyCollection<T> Data { get; init; } = [];

    /// <summary>
    /// True if this List is paginated and there is a page beyond the current page.
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool HasMore { get; init; }

    /// <summary>
    /// If there is a page beyond the current page, this field will contain a full API URI to that
    /// page. You may submit a HTTP GET request to that URI to continue paginating forward on this List.
    /// </summary>
    [JsonPropertyName("next_page")]
    public Uri? NextPage { get; init; }

    /// <summary>
    /// If this is a list of Card objects, this field will contain the total number of cards found
    /// across all pages.
    /// </summary>
    [JsonPropertyName("total_cards")]
    public int? TotalCards { get; init; }

    /// <summary>
    /// An array of human-readable warnings issued when generating this list, as strings. Warnings
    /// are non-fatal issues that the API discovered with your input. In general, they indicate that
    /// the List will not contain the all of the information you requested. You should fix the
    /// warnings and re-submit your request.
    /// </summary>
    [JsonPropertyName("warnings")]
    public IReadOnlyCollection<string> Warnings { get; init; } = [];
}
