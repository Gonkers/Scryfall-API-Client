using System.Text.Json.Serialization;

namespace ScryfallApi.Client.Models;

/// <summary>
/// <para>Rulings represent Oracle rulings, Wizards of the Coast set release notes, or Scryfall notes
/// for a particular card.</para>
/// <para>If two cards have the same name, they will have the same set of rulings objects. If a card
/// has rulings, it usually has more than one.</para>
/// <para>Rulings with a scryfall source have been added by the Scryfall team, either to provide
/// additional context for the card, or explain how the card works in an unofficial format (such as
/// Duel Commander).</para>
/// </summary>
public class Ruling : BaseItem
{
    /// <summary>
    /// The Oracle ID of the card this ruling is associated with.
    /// </summary>
    [JsonPropertyName("oracle_id")]
    public Guid OracleId { get; init; }

    /// <summary>
    /// A computer-readable string indicating which company produced this ruling, either wotc or scryfall.
    /// </summary>
    [JsonPropertyName("source")]
    public string Soruce { get; init; }

    /// <summary>
    /// The date when the ruling or note was published.
    /// </summary>
    [JsonPropertyName("published_at")]
    public DateOnly PublishedAt { get; init; }

    /// <summary>
    /// The text of the ruling.
    /// </summary>
    [JsonPropertyName("comment")]
    public string Comment { get; init; }
}
