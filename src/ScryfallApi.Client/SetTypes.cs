namespace ScryfallApi.Client;

/// <summary>
/// Scryfall provides an overall categorization for each Set in the set_type property.
/// </summary>
public static class SetTypes
{
    /// <summary>An Arena set designed for Alchemy</summary>
    public static SetType Alchemy { get; } = new("alchemy", "An Arena set designed for Alchemy");

    /// <summary>Archenemy sets</summary>
    public static SetType Archenemy { get; } = new("archenemy", "Archenemy sets");

    /// <summary>A Commander-oriented gift set</summary>
    public static SetType Arsenal { get; } = new("arsenal", "A Commander-oriented gift set");

    /// <summary>A gift box set</summary>
    public static SetType Box { get; } = new("box", "A gift box set");

    /// <summary>Commander preconstructed decks</summary>
    public static SetType Commander { get; } = new("commander", "Commander preconstructed decks");

    /// <summary>A yearly Magic core set (Tenth Edition, etc)</summary>
    public static SetType Core { get; } = new("core", "A yearly Magic core set (Tenth Edition, etc)");

    /// <summary>Special draft sets, like Conspiracy and Battlebond</summary>
    public static SetType DraftInnovation { get; } = new("draft_innovation", "Special draft sets, like Conspiracy and Battlebond");

    /// <summary>Duel Decks</summary>
    public static SetType DuelDeck { get; } = new("duel_deck", "Duel Decks");

    /// <summary>A rotational expansion set in a block (Zendikar, etc)</summary>
    public static SetType Expansion { get; } = new("expansion", "A rotational expansion set in a block (Zendikar, etc)");

    /// <summary>From the Vault gift sets</summary>
    public static SetType FromTheVault { get; } = new("from_the_vault", "From the Vault gift sets");

    /// <summary>A funny un-set or set with funny promos (Unglued, Happy Holidays, etc)</summary>
    public static SetType Funny { get; } = new("funny", "A funny un-set or set with funny promos (Unglued, Happy Holidays, etc)");

    /// <summary>Masterpiece Series premium foil cards</summary>
    public static SetType Masterpiece { get; } = new("masterpiece", "Masterpiece Series premium foil cards");

    /// <summary>A reprint set that contains no new cards (Modern Masters, etc)</summary>
    public static SetType Masters { get; } = new("masters", "A reprint set that contains no new cards (Modern Masters, etc)");

    /// <summary>A set made up of gold-bordered, oversize, or trophy cards that are not legal</summary>
    public static SetType Memorabilia { get; } = new("memorabilia", "A set made up of gold-bordered, oversize, or trophy cards that are not legal");

    /// <summary>A set that contains minigame card inserts from booster packs</summary>
    public static SetType Minigame { get; } = new("minigame", "A set that contains minigame card inserts from booster packs");

    /// <summary>Planechase sets</summary>
    public static SetType Planechase { get; } = new("planechase", "Planechase sets");

    /// <summary>Premium Deck Series decks</summary>
    public static SetType Premium_deck { get; } = new("premium_deck", "Premium Deck Series decks");

    /// <summary>A set that contains purely promotional cards</summary>
    public static SetType Promo { get; } = new("promo", "A set that contains purely promotional cards");

    /// <summary>Spellbook series gift sets</summary>
    public static SetType Spellbook { get; } = new("spellbook", "Spellbook series gift sets");

    /// <summary>A starter/introductory set (Portal, etc)</summary>
    public static SetType Starter { get; } = new("starter", "A starter/introductory set (Portal, etc)");

    /// <summary>A set made up of tokens and emblems.</summary>
    public static SetType Token { get; } = new("token", "A set made up of tokens and emblems.");

    /// <summary>Magic Online treasure chest prize sets</summary>
    public static SetType Treasure_chest { get; } = new("treasure_chest", "Magic Online treasure chest prize sets");

    /// <summary>Vanguard card sets</summary>
    public static SetType Vanguard { get; } = new("vanguard", "Vanguard card sets");
}

/// <summary>
/// Scryfall provides an overall categorization for each Set in the set_type property.
/// </summary>
/// <param name="Text">The 'type' code used to identify the set type.</param>
/// <param name="Description">The description of the set type.</param>
public record SetType(string Text, string Description);