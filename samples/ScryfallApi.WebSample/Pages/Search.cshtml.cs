using System;
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
        public string Query { get; set; }

        public SearchModel(ScryfallApiClient scryfallApi)
        {
            _scryfallApi = scryfallApi ?? throw new ArgumentNullException(nameof(scryfallApi));
        }

        public void OnGet()
        {
        }

        public async Task<ActionResult> OnPostAsync()
        {
            var options = new SearchOptions
            {
                Sort = SearchOptions.CardSort.Cmc,
                Direction = SearchOptions.SortDirection.Desc
            };

            Results = await _scryfallApi.Cards.Search(Query, 1, options);

            return Page();
        }
    }
}