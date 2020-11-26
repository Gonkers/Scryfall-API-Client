using ScryfallApi.Client.Apis;

namespace ScryfallApi.Client
{
    public interface IScryfallApiClient
    {
        ICards Cards { get; }
        ICatalogs Catalogs { get; }
        ISets Sets { get; }
        ISymbology Symbology { get; }
    }
}