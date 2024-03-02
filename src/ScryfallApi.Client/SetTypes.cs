namespace ScryfallApi.Client;

/// <summary>
/// Scryfall provides an overall categorization for each Set in the set_type property.
/// </summary>
public static class SetTypes
{
    /// <summary>An Arena set designed for Alchemy</summary>
    public static SetType Alchemy { get; } = new SetType("alchemy", "An Arena set designed for Alchemy");

    /// <summary>Archenemy sets</summary>
    public static SetType Archenemy { get; } = new SetType("archenemy", "Archenemy sets");

    /// <summary>A Commander-oriented gift set</summary>
    public static SetType Arsenal { get; } = new SetType("arsenal", "A Commander-oriented gift set");

    /// <summary>A gift box set</summary>
    public static SetType Box { get; } = new SetType("box", "A gift box set");

    /// <summary>Commander preconstructed decks</summary>
    public static SetType Commander { get; } = new SetType("commander", "Commander preconstructed decks");

    /// <summary>A yearly Magic core set (Tenth Edition, etc)</summary>
    public static SetType Core { get; } = new SetType("core", "A yearly Magic core set (Tenth Edition, etc)");

    /// <summary>Special draft sets, like Conspiracy and Battlebond</summary>
    public static SetType DraftInnovation { get; } = new SetType("draft_innovation", "Special draft sets, like Conspiracy and Battlebond");

    /// <summary>Duel Decks</summary>
    public static SetType DuelDeck { get; } = new SetType("duel_deck", "Duel Decks");

    /// <summary>A rotational expansion set in a block (Zendikar, etc)</summary>
    public static SetType Expansion { get; } = new SetType("expansion", "A rotational expansion set in a block (Zendikar, etc)");

    /// <summary>From the Vault gift sets</summary>
    public static SetType FromTheVault { get; } = new SetType("from_the_vault", "From the Vault gift sets");

    /// <summary>A funny un-set or set with funny promos (Unglued, Happy Holidays, etc)</summary>
    public static SetType Funny { get; } = new SetType("funny", "A funny un-set or set with funny promos (Unglued, Happy Holidays, etc)");

    /// <summary>Masterpiece Series premium foil cards</summary>
    public static SetType Masterpiece { get; } = new SetType("masterpiece", "Masterpiece Series premium foil cards");

    /// <summary>A reprint set that contains no new cards (Modern Masters, etc)</summary>
    public static SetType Masters { get; } = new SetType("masters", "A reprint set that contains no new cards (Modern Masters, etc)");

    /// <summary>A set made up of gold-bordered, oversize, or trophy cards that are not legal</summary>
    public static SetType Memorabilia { get; } = new SetType("memorabilia", "A set made up of gold-bordered, oversize, or trophy cards that are not legal");

    /// <summary>A set that contains minigame card inserts from booster packs</summary>
    public static SetType Minigame { get; } = new SetType("minigame", "A set that contains minigame card inserts from booster packs");

    /// <summary>Planechase sets</summary>
    public static SetType Planechase { get; } = new SetType("planechase", "Planechase sets");

    /// <summary>Premium Deck Series decks</summary>
    public static SetType Premium_deck { get; } = new SetType("premium_deck", "Premium Deck Series decks");

    /// <summary>A set that contains purely promotional cards</summary>
    public static SetType Promo { get; } = new SetType("promo", "A set that contains purely promotional cards");

    /// <summary>Spellbook series gift sets</summary>
    public static SetType Spellbook { get; } = new SetType("spellbook", "Spellbook series gift sets");

    /// <summary>A starter/introductory set (Portal, etc)</summary>
    public static SetType Starter { get; } = new SetType("starter", "A starter/introductory set (Portal, etc)");

    /// <summary>A set made up of tokens and emblems.</summary>
    public static SetType Token { get; } = new SetType("token", "A set made up of tokens and emblems.");

    /// <summary>Magic Online treasure chest prize sets</summary>
    public static SetType Treasure_chest { get; } = new SetType("treasure_chest", "Magic Online treasure chest prize sets");

    /// <summary>Vanguard card sets</summary>
    public static SetType Vanguard { get; } = new SetType("vanguard", "Vanguard card sets");
}

/// <summary>
/// Scryfall provides an overall categorization for each Set in the set_type property.
/// </summary>
/// <param name="Text">The 'type' code used to identify the set type.</param>
/// <param name="Description">The description of the set type.</param>
public record SetType(string Text, string Description);