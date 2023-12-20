using ScryfallExtractor.Core.Models;

namespace ScryfallExtractor.Service.Tests {
    public class ScryfallImportingServiceTests {
        [Fact]
        public void EndToEndExtraction() {
            try {
                var service = new ScryfallImportingService();

                Stream fileStream = File.OpenRead(@"C:\Users\ckaru\Downloads\all-cards-20231206221731.json");

                var importedCards = service.ImportCards(fileStream)
                    .Where(x => x.Legalities.Commander is CardLegality.Legal || x.Legalities.Duel is CardLegality.Legal)
                    .ToList();

                var exportedSummaries = service.ExportCardSummary(importedCards)
                    .ToList();

                var types = exportedSummaries.Select(x => x.Type).Distinct().OrderBy(x => x).ToList();

                var csvFileStream = File.Create($@"C:\Users\ckaru\Downloads\cards-summary-{DateTime.Now.Ticks}.csv");

                using var sw = new StreamWriter(csvFileStream);
                
                sw.WriteLine(CardSummary.ExportHeaderToCsv());
                
                foreach (var summary in exportedSummaries) {
                    sw.WriteLine(summary.ExportUnitToCsv());
                }

                sw.Close();
            } catch (Exception ex) {
                Assert.Fail($"{ex.GetType()}: {ex.Message}");
            }
        }
    }
}