using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ScryfallApi.Client;
using ScryfallApi.Client.Models;

namespace ScryfallApi.WebSample.Pages
{
    public class SearchModel : PageModel
    {
        ScryfallApiClient _scryfallApi { get; }

        [BindProperty]
        public ResultList<Card> Results { get; set; }

        [BindProperty]
        public string Query {get; set;}

        public SearchModel(ScryfallApiClient scryfallApi)
        {
            _scryfallApi = scryfallApi ?? throw new ArgumentNullException(nameof(scryfallApi));
        }

        public void OnGet()
        {
        }

        public async Task<ActionResult> OnPostAsync()
        {
            Results = await _scryfallApi.Cards.Search(Query, 1, CardSort.Name);

            return Page();
        }
    }
}