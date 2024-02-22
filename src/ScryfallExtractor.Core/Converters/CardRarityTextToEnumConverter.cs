using System.Text.Json.Serialization;
using System.Text.Json;
using ScryfallExtractor.Core.Models.Input;

namespace ScryfallExtractor.Core.Converters
{
    public class CardRarityTextToEnumConverter : JsonConverter<CardRarity> {
        private const string CommonString = "common";
        private const string UncommonString = "uncommon";
        private const string RareString = "rare";
        private const string MythicString = "mythic";
        private const string SpecialString = "special";
        private const string BonusString = "bonus";

        public override CardRarity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            if (reader.TokenType is JsonTokenType.String) {
                var text = reader.GetString();

                return text switch {
                    CommonString => CardRarity.Common,
                    UncommonString => CardRarity.Uncommon,
                    RareString => CardRarity.Rare,
                    MythicString => CardRarity.Mythic,
                    SpecialString => CardRarity.Special,
                    BonusString => CardRarity.Bonus,
                    _ => throw new JsonException($"Unexpected value: {text}")
                };

            } else {
                throw new JsonException($"Type mismatch: {reader.TokenType}.");
            }
        }

        public override void Write(Utf8JsonWriter writer, CardRarity value, JsonSerializerOptions options) {
            throw new NotImplementedException();
        }
    }
}
