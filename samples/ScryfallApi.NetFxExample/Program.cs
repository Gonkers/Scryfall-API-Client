using ScryfallApi.Client;
using ScryfallApi.Client.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ScryfallApi.NetFxExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient { BaseAddress = ScryfallApiClientConfig.GetDefault().ScryfallApiBaseAddress };
            var client = new ScryfallApiClient(httpClient);
            do
            {
                try
                {
                    var randomCard = await client.Cards.GetRandom();
                    Console.Clear();
                    Console.WriteLine(DrawCard(randomCard));
                }
                catch (ScryfallApiException ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine($"Status Code: {ex.ResponseStatusCode}");
                    Console.WriteLine($"Remote Call: {ex.RequestMethod} {ex.RequestUri}");
                }
                Console.WriteLine(Environment.NewLine + "Press any key for a new card. Press Esc to quit.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static string DrawCard(Card card)
        {
            const int TitleWidth = 31;
            var cardName = card.Name + new string(' ', TitleWidth);
            var title = cardName.Substring(0, TitleWidth - 1 - (card.ManaCost?.Length ?? 0)) + " " + card.ManaCost;
            var type = (card.TypeLine + new string(' ', TitleWidth)).Substring(0, TitleWidth);

            var cardText = SplitOnWidth(card.OracleText, 29);
            var text0 = cardText.Count > 0 ? cardText[0] : new string(' ', 29);
            var text1 = cardText.Count > 1 ? cardText[1] : new string(' ', 29);
            var text2 = cardText.Count > 2 ? cardText[2] : new string(' ', 29);
            var text3 = cardText.Count > 3 ? cardText[3] : new string(' ', 29);

            return $@"
/---------------------------------\
| {title} |
|+-------------------------------+|
||                  \||/         ||
||                  |  @___oo    ||
||        /\  /\   / (__,,,,|    ||
||       ) /^\) ^\/ _)           ||
||       )   /^\/   _)           ||
||       )   _ /  / _)           ||
||   /\  )/\/ ||  | )_)          ||
||  <  >      |(,,) )__)         ||
||   ||      /    \)___)\        ||
||   | \____(      )___) )___    ||
||    \______(_______;;; __;;;   ||
|+-------------------------------+|
| {type} |
|+-------------------------------+|
|| {text0} ||
|| {text1} ||
|| {text2} ||
|| {text3} ||
|+-------------------------------+|
\---------------------------------/";
        }

        static List<string> SplitOnWidth(string text, int width)
        {
            var textLines = new List<string>();
            if (text is null) return textLines;

            var rawLines = text.Split(new[] { "\n" }, StringSplitOptions.None);
            for (int i = 0; i < rawLines.Length; i++)
            {
                var line = rawLines[i];
                while (line.Length > 0)
                {
                    if (line.Length <= width)
                    {
                        textLines.Add((line + new string(' ', width)).Substring(0, width));
                        line = string.Empty;
                    }
                    else
                    {
                        textLines.Add(line.Substring(0, width));
                        line = line.Remove(0, width);
                    }
                }
            }
            return textLines;
        }
    }
}
