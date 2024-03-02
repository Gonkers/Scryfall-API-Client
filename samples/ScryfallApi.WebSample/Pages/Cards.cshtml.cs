using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ScryfallApi.Client;
using ScryfallApi.Client.Models;

namespace ScryfallApi.WebSample.Pages
{
    public class CardsModel : PageModel
    {
        private readonly ScryfallApiClient _scryfallApi;
        public List<SelectListItem> SetList { get; set; } = [];
        public IReadOnlyCollection<Card> CardList { get; set; } = [];

        public CardsModel(ScryfallApiClient scryfallApi)
        {
            _scryfallApi = scryfallApi ?? throw new ArgumentNullException(nameof(scryfallApi));
        }

        public async Task<IActionResult> OnGet([FromQuery] string set)
        {
            var sets = await _scryfallApi.Sets.Get();
            SetList = sets?.Data.OrderBy(s => s.Name).Select(s => new SelectListItem(s.Name, s.Code)).ToList() ?? [];

            var selectedItem = SetList.FirstOrDefault(li => li.Value.Equals(set));
            if (selectedItem is not null)
            {
                selectedItem.Selected = true;
                CardList = (await _scryfallApi.Cards.Search($"e:{selectedItem.Value}", 1, SearchOptions.CardSort.Name))?.Data ?? [];
            }
            else
                CardList = [];

            return Page();
        }
    }
}
