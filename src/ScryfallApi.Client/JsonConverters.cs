using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ScryfallApi.Client
{
    public class DecimalAsStringConverter : JsonConverter<decimal?>
    {
        public override decimal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return value is null ? null : decimal.Parse(value);
        }

        public override void Write(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options) => writer.WriteStringValue(value?.ToString());
    }
}
