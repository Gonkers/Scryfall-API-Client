using Newtonsoft.Json;

namespace ScryfallApi.Client.Models
{
    public class Error : BaseItem
    {
        /// <summary>
        /// An integer HTTP status code for this error.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// A computer-friendly string representing the appropriate HTTP status code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// A human-readable string explaining the error.
        /// </summary>
        [JsonProperty("details")]
        public string Details { get; set; }

        /// <summary>
        /// A computer-friendly string that provides additional context for the main error. For
        /// example, an endpoint many generate HTTP 404 errors for different kinds of input. This
        /// field will provide a label for the specific kind of 404 failure, such as ambiguous.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// If your input also generated non-failure warnings, they will be provided as
        /// human-readable strings in this array.
        /// </summary>
        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }
}