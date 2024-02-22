using System.Text.Json.Serialization;
using System.Text.Json;
using ScryfallExtractor.Core.Models.Input;

namespace ScryfallExtractor.Core.Converters
{
    public class ColorPieTextToEnumConverter : JsonConverter<ColorPie> {
        public override ColorPie Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            if (reader.TokenType is JsonTokenType.StartArray) {
                var colorPie = ColorPie.None;
                reader.Read();

                while (reader.TokenType is not JsonTokenType.EndArray) {
                    var text = reader.GetString();

                    colorPie |= text switch {
                        "U" => ColorPie.Blue,
                        "G" => ColorPie.Green,
                        "R" => ColorPie.Red,
                        "W" => ColorPie.White,
                        "B" => ColorPie.Black,
                        _ => throw new JsonException($"Unexpected value: {text}")
                    };

                    reader.Read();
                }
                return colorPie;

            } else {
                throw new JsonException($"Type mismatch: {reader.TokenType}.");
            }
        }

        public override void Write(Utf8JsonWriter writer, ColorPie value, JsonSerializerOptions options) {
            throw new NotImplementedException();
        }
    }
}
