using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

/// <summary>
/// An Error object represents a failure to find information or understand the input
/// you provided to the API. Error objects are always transmitted with the appropriate
/// 4XX or 5XX HTTP status code.
/// </summary>
public class Error : BaseItem
{
    /// <summary>
    /// An integer HTTP status code for this error.
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; init; }

    /// <summary>
    /// A computer-friendly string representing the appropriate HTTP status code.
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; init; }

    /// <summary>
    /// A human-readable string explaining the error.
    /// </summary>
    [JsonPropertyName("details")]
    public string Details { get; init; }

    /// <summary>
    /// A computer-friendly string that provides additional context for the main error. For
    /// example, an endpoint many generate HTTP 404 errors for different kinds of input. This
    /// field will provide a label for the specific kind of 404 failure, such as ambiguous.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// If your input also generated non-failure warnings, they will be provided as
    /// human-readable strings in this array.
    /// </summary>
    [JsonPropertyName("warnings")]
    public IReadOnlyCollection<string> Warnings { get; init; } = [];
}
