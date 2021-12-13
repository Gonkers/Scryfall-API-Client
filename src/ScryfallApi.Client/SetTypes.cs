using System.Collections.ObjectModel;

namespace ScryfallApi.Client;

public static class SetTypes
{
    private static Dictionary<string, SetType> GetSetTypes() =>
        new()
        {
            { "core", new SetType("core", "A yearly Magic core set (Tenth Edition, etc)") },
            { "expansion", new SetType("expansion", "A rotational expansion set in a block (Zendikar, etc)") },
            { "masters", new SetType("masters", "A reprint set that contains no new cards (Modern Masters, etc)") },
            { "masterpiece", new SetType("masterpiece", "Masterpiece Series premium foil cards") },
            { "from_the_vault", new SetType("from_the_vault", "From the Vault gift sets") },
            { "spellbook", new SetType("spellbook", "Spellbook series gift sets") },
            { "premium_deck", new SetType("premium_deck", "Premium Deck Series decks") },
            { "duel_deck", new SetType("duel_deck", "Duel Decks") },
            { "commander", new SetType("commander", "Commander preconstructed decks") },
            { "planechase", new SetType("planechase", "Planechase sets") },
            { "conspiracy", new SetType("conspiracy", "Conspiracy sets") },
            { "archenemy", new SetType("archenemy", "Archenemy sets") },
            { "vanguard", new SetType("vanguard", "Vanguard card sets") },
            { "funny", new SetType("funny", "A funny un-set or set with funny promos (Unglued, Happy Holidays, etc)") },
            { "starter", new SetType("starter", "A starter/introductory set (Portal, etc)") },
            { "box", new SetType("box", "A gift box set") },
            { "promo", new SetType("promo", "A set that contains purely promotional cards") },
            { "token", new SetType("token", "A set made up of tokens and emblems.") },
            { "memorabilia", new SetType("memorabilia", "A set made up of gold-bordered, oversize, or trophy cards that are not legal") },
        };

    private static Lazy<ReadOnlyDictionary<string, SetType>> _lazySetTypes =
        new(() => new ReadOnlyDictionary<string, SetType>(GetSetTypes()));

    public static SetType Core => _lazySetTypes.Value["core"];
    public static SetType Expansion => _lazySetTypes.Value["expansion"];
    public static SetType Masters => _lazySetTypes.Value["masters"];
    public static SetType Masterpiece => _lazySetTypes.Value["masterpiece"];
    public static SetType FromTheVault => _lazySetTypes.Value["from_the_vault"];
    public static SetType Spellbook => _lazySetTypes.Value["spellbook"];
    public static SetType PremiumDeck => _lazySetTypes.Value["premium_deck"];
    public static SetType DuelDeck => _lazySetTypes.Value["duel_deck"];
    public static SetType Commander => _lazySetTypes.Value["commander"];
    public static SetType Planechase => _lazySetTypes.Value["planechase"];
    public static SetType Conspiracy => _lazySetTypes.Value["conspiracy"];
    public static SetType Archenemy => _lazySetTypes.Value["archenemy"];
    public static SetType Vanguard => _lazySetTypes.Value["vanguard"];
    public static SetType Funny => _lazySetTypes.Value["funny"];
    public static SetType Starter => _lazySetTypes.Value["starter"];
    public static SetType Box => _lazySetTypes.Value["box"];
    public static SetType Promo => _lazySetTypes.Value["promo"];
    public static SetType Token => _lazySetTypes.Value["token"];
    public static SetType Memorabilia => _lazySetTypes.Value["memorabilia"];
}

public class SetType : IEquatable<string>, IComparable, IComparable<string>
{
    protected internal SetType(string text, string description)
    {
        Text = text;
        Description = description;
    }

    public string Text { get; }
    public string Description { get; }

    public int CompareTo(string other) => Text.CompareTo(other);
    public int CompareTo(object other) => CompareTo((other as SetType)?.Text);
    public bool Equals(string other) => Text.Equals(other);
    public override string ToString() => Text;
}
