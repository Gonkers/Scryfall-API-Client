using ScryfallApi.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Example of pulling the config from IConfiguration
/*
var scryfallApiClientConfig = Configuration.GetSection("ScryfallApiClient").Get<ScryfallApiClientConfig>();
services.AddScryfallApiClient(scryfallApiClientConfig);
*/

// Example of using default settings
/*
services.AddScryfallApiClient();
*/

// Example of customizing settings with code
builder.Services.AddScryfallApiClient(config =>
{
    config.CacheDuration = TimeSpan.FromMinutes(30);
    config.UseSlidingCacheExpiration = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
