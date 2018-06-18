using Newtonsoft.Json;
using System;

namespace ScryfallApi.Client.Models
{
    class Catalog : BaseItem
    {
        [JsonProperty("uri")]
        public Uri Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }
}