using Microsoft.AspNetCore.Mvc.RazorPages;
using ScryfallApi.Client;
using ScryfallApi.Client.Models;

namespace ScryfallApi.WebSample.Pages
{
    public class SetsModel : PageModel
    {
        private readonly ScryfallApiClient _scryfallApi;
        public List<Set> MtgExpansions { get; set; } = [];

        public SetsModel(ScryfallApiClient scryfallApi)
        {
            _scryfallApi = scryfallApi ?? throw new ArgumentNullException(nameof(scryfallApi));
        }

        public async Task OnGet()
        {
            var setsResult = await _scryfallApi.Sets.Get();
            MtgExpansions = [.. setsResult?.Data.Where(s => s.SetType.Equals("expansion") && !s.IsDigital) ?? []];
        }
    }
}
