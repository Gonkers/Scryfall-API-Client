using ScryfallApi.Client.Models;
using System.Net;

namespace ScryfallApi.Client;

/// <summary>
/// Represents an exception thrown by the Scryfall API client.
/// </summary>
public class ScryfallApiException : Exception
{
    /// <summary>
    /// Constructs a new instance of <see cref="ScryfallApiException"/>.
    /// </summary>
    public ScryfallApiException() { }

    /// <summary>
    /// Constructs a new instance of <see cref="ScryfallApiException"/>.
    /// </summary>
    /// <param name="message"></param>
    public ScryfallApiException(string message) : base(message) { }

    /// <summary>
    /// Constructs a new instance of <see cref="ScryfallApiException"/>.
    /// </summary>
    /// <param name="message"></param>
    /// <param name="innerException"></param>
    public ScryfallApiException(string? message, Exception? innerException) : base(message, innerException) { }

    /// <summary>
    /// The status code of the response from the Scryfall API.
    /// </summary>
    public HttpStatusCode ResponseStatusCode { get; init; }

    /// <summary>
    /// The URI of the request that caused the exception.
    /// </summary>
    public Uri RequestUri { get; init; } = new(ScryfallApiClientConfig.ScryfallApiAddress);

    /// <summary>
    /// The HTTP method of the request that caused the exception.
    /// </summary>
    public HttpMethod RequestMethod { get; init; } = HttpMethod.Get;

    /// <summary>
    /// The error text returned by the Scryfall API.
    /// </summary>
    public Error ScryfallError { get; init; } = new();
}
