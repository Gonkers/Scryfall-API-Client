using Microsoft.AspNetCore.Mvc.RazorPages;
using ScryfallApi.Client;
using ScryfallApi.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScryfallApi.WebSample.Pages
{
    public class SetsModel : PageModel
    {
        private readonly ScryfallApiClient _scryfallApi;
        public List<Set> MtgExpansions { get; set; }

        public SetsModel(ScryfallApiClient scryfallApi)
        {
            _scryfallApi = scryfallApi ?? throw new ArgumentNullException(nameof(scryfallApi));
        }

        public async Task OnGet()
        {
            var setsResult = await _scryfallApi.Sets.Get();
            MtgExpansions = new List<Set>(setsResult.Data.
                Where(s => s.SetType.Equals("expansion") &&  !s.IsDigital));
        }
    }
}
