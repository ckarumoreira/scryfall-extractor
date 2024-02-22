using System.Text.Json.Serialization;
using System.Text.Json;
using ScryfallExtractor.Core.Models.Input;

namespace ScryfallExtractor.Core.Converters
{
    public class CardLegalityTextToEnumConverter : JsonConverter<CardLegality> {
        private const string LegalString = "legal";
        private const string NotLegalString = "not_legal";
        private const string RestrictedString = "restricted";
        private const string BannedString = "banned";

        public override CardLegality Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            switch (reader.TokenType) {
                case JsonTokenType.String:
                    var text = reader.GetString();

                    return text switch {
                        LegalString => CardLegality.Legal,
                        NotLegalString => CardLegality.NotLegal,
                        RestrictedString => CardLegality.Restricted,
                        BannedString => CardLegality.Banned,
                        _ => throw new JsonException($"Text mismatch: {text}.")
                    };
                default:
                    throw new JsonException($"Type mismatch: {reader.TokenType}.");
            }
        }

        public override void Write(Utf8JsonWriter writer, CardLegality value, JsonSerializerOptions options) {
            writer.WriteStringValue(value switch {
                CardLegality.NotLegal => NotLegalString,
                CardLegality.Legal => LegalString,
                CardLegality.Restricted => RestrictedString,
                CardLegality.Banned => BannedString,
                _ => throw new JsonException($"Unexptected value: {value}")
            });
        }
    }
}
