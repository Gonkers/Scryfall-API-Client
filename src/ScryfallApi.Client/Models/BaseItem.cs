using Newtonsoft.Json;

namespace ScryfallApi.Client.Models
{
    public abstract class BaseItem
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        internal Error Error { get; set; }
    }
}