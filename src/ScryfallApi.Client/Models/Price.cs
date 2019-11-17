using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScryfallApi.Client.Models
{
    public class Price : BaseItem
    {
        [JsonProperty("usd")]
        public decimal? Usd { get; set; }

        [JsonProperty("usd_foil")]
        public decimal? UsdFoil { get; set; }

        [JsonProperty("eur")]
        public decimal? Eur { get; set; }

        [JsonProperty("eur_foil")]
        public decimal? EurFoil { get; set; }

        [JsonProperty("tix")]
        public decimal? Tix { get; set; }
    }
}