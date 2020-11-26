using System;

namespace ScryfallApi.Client
{
    public class ScryfallApiClientConfig
    {
        public Uri ScryfallApiBaseAddress { get; set; } = new Uri("https://api.scryfall.com/");
        public bool EnableCaching { get; set; } = true;
        public TimeSpan CacheDuration { get; set; } = TimeSpan.FromMinutes(30);
        public bool UseSlidingCacheExpiration { get; set; } = false;

        internal ScryfallApiClientConfig Clone() => new ScryfallApiClientConfig
        {
            ScryfallApiBaseAddress = ScryfallApiBaseAddress,
            CacheDuration = CacheDuration,
            EnableCaching = EnableCaching,
            UseSlidingCacheExpiration = UseSlidingCacheExpiration
        };

        public static ScryfallApiClientConfig GetDefault() => new ScryfallApiClientConfig();
    }
}