using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ScryfallApi.Client;

/// <summary>
/// Scryfall uses strings to encode their monetary amounts in US format rather than simply using a
/// JSON number. System.Text.Json is very strict on number conversions, so converting a string to
/// a decimal needs some customization.
/// </summary>
internal class UsDecimalAsStringConverter : JsonConverter<decimal?>
{
    public override decimal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        var numberFormat = CultureInfo.GetCultureInfo("en-US").NumberFormat;
        return value is null ? null : decimal.Parse(value, numberFormat);
    }

    public override void Write(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options) => writer.WriteStringValue(value?.ToString());
}
