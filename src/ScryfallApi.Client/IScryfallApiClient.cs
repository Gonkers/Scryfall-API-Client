using ScryfallApi.Client.Apis;

namespace ScryfallApi.Client;

/// <summary>
/// REST client for retrieving data from https://api.scryfall.com/. This software has no affiliation
/// with Scryfall.com
/// </summary>
public interface IScryfallApiClient
{

    ///<inheritdoc cref="ICards"/>
    ICards Cards { get; }

    ///<inheritdoc cref="ICatalogs"/>
    ICatalogs Catalogs { get; }

    ///<inheritdoc cref="ISets"/>
    ISets Sets { get; }

    ///<inheritdoc cref="ISymbology"/>
    ISymbology Symbology { get; }
}
