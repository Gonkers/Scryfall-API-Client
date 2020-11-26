using ScryfallApi.Client.Models;
using System;
using System.Net;
using System.Net.Http;

namespace ScryfallApi.Client
{
    public class ScryfallApiException : Exception
    {
        public ScryfallApiException(string message) : base(message) { }
        public HttpStatusCode ResponseStatusCode { get; set; }
        public Uri RequestUri { get; set; }
        public HttpMethod RequestMethod { get; set; }
        public Error ScryfallError { get; set; }
    }
}