using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScryfallApi.Client;
using ScryfallApi.Client.Models;

namespace ScryfallApi.WebSample.Pages
{
    public class NamedModel : PageModel
    {
        ScryfallApiClient _scryfallApi { get; }
        public Card NamedCard { get; set; }

        [BindProperty]
        public string Query { get; set; }

        public NamedModel(ScryfallApiClient scryfallApi)
        {
            _scryfallApi = scryfallApi ?? throw new ArgumentNullException(nameof(scryfallApi));
        }

        public void OnGet()
        {
        }

        public async Task<ActionResult> OnPostAsync()
        {
            NamedCard = await _scryfallApi.Cards.Named(Query, true);
            return Page();
        }
    }
}