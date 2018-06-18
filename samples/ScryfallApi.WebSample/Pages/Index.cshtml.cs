using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScryfallApi.Client;
using ScryfallApi.Client.Models;

namespace ScryfallApi.WebSample.Pages
{
    public class IndexModel : PageModel
    {
        ScryfallApiClient _scryfallApi { get; }

        public IndexModel(ScryfallApiClient scryfallApi)
        {
            _scryfallApi = scryfallApi ?? throw new ArgumentNullException(nameof(scryfallApi));
        }

        public async Task OnGet()
        {
            RandomCard = await _scryfallApi.Cards.GetRandom();
        }

        public Card RandomCard { get; set; }
    }
}