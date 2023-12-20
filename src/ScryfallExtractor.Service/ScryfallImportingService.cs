using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using ScryfallExtractor.Core.Models;
using ScryfallExtractor.Core.Services;

namespace ScryfallExtractor.Service {
    public class ScryfallImportingService : IScryfallImportingService {
        private readonly JsonSerializerOptions _serializerOptions;

        public ScryfallImportingService() {
            _serializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.General);
        }

        public IEnumerable<CardSummary> ExportCardSummary(IEnumerable<CardInput> cardInputList) {
            var summaryEnumerable = from card in cardInputList
            group card by card.Name into grp1
            let rarity = grp1.Select(x => x.Rarity)
            select new CardSummary() {
                Name = grp1.Key,
                Cmc = (ushort)grp1.First().Cmc,
                ColorIdentity = grp1.First().ColorIdentity,
                HighestRarity = rarity.Max(),
                LowestRarity = rarity.Min(),
                IsDigitalOnly = !grp1.Any(x => x.Games.Contains("paper", StringComparer.OrdinalIgnoreCase)),
                ManaCost = grp1.First().ManaCost,
                Type = grp1.First().TypeLine,
                ImageUri = grp1.Where(x => x.ImageUris is not null).FirstOrDefault()?.ImageUris.Large
            };

            return summaryEnumerable;
        }

        public IEnumerable<CardInput> ImportCards(Stream cardSourceStream) {
            return JsonSerializer.Deserialize<IEnumerable<CardInput>>(cardSourceStream, _serializerOptions); 
        }
    }
}
