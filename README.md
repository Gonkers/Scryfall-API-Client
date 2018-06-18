# Scryfall API Client
## Getting Started
Until I can get better documentation, see the [samples project](https://github.com/Gonkers/Scryfall-API-Client/tree/master/samples/ScryfallApi.WebSample) for examples.

---
## .NET Core Instructions
### Add a service definition to your `startup.cs` file's `ConfigureServices` method.
```c#
services.AddHttpClient<ScryfallApiClient>(client =>
{
    client.BaseAddress = new Uri("https://api.scryfall.com/");
});
```
### Add a `ScryfallApiClient` parameter and member to your Controller or Razor Page
```c#
ScryfallApiClient _scryfallApi { get; }

public IndexModel(ScryfallApiClient scryfallApi)
{
    _scryfallApi = scryfallApi ?? throw new ArgumentNullException(nameof(scryfallApi));
}
```
### Use the client
```c#
var randomCard = await _scryfallApi.Cards.GetRandom();
```