using System.Threading.Tasks;
using ScryfallApi.Client.Models;

namespace ScryfallApi.Client.Apis
{
    public interface ISymbology
    {
        /// <summary>
        /// Retrieve all card symbols
        /// </summary>
        /// <returns></returns>
        Task<ResultList<Symbol>> Get();

        /// <summary>
        /// Parses the given mana cost parameter and returns Scryfall’s interpretation.
        /// </summary>
        /// <returns></returns>
        Task<ManaCost> ParseMana(string cost);
    }
}