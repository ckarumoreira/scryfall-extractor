using System.Text.Json;
using ScryfallExtractor.Core.Models;
using ScryfallExtractor.Core.Services;

namespace ScryfallExtractor.Service {
    public class ScryfallSourceUpdateService : IScryfallSourceUpdateService {
        public async Task<bool> IsSourceBulkUpToDate(ExtractorConfiguration configuration) {
            using HttpClient client = new HttpClient();
            var result = await client.GetAsync("https://api.scryfall.com/bulk-data/all-cards");
            
            if (result.IsSuccessStatusCode) {
                var stream = result.Content.ReadAsStream();
                var bulkData = JsonSerializer.Deserialize<BulkData?>(stream);


                if (bulkData is not null) {
                    configuration.LastAvailableBulk = bulkData;

                    if (configuration.CurrentBulk is null) {
                        return false;
                    }

                    return configuration.CurrentBulk.UpdatedAt == bulkData?.UpdatedAt;
                }

                throw new ArgumentNullException(nameof(bulkData));
            }

            throw new HttpRequestException("Couldn't retrieve bulk data information.");
        }

        public async Task UpdateSourceBulk(ExtractorConfiguration configuration) {
            using HttpClient client = new HttpClient();
            var result = await client.GetStreamAsync(configuration.LastAvailableBulk.DownloadUri);
            
            if (File.Exists(configuration.BulkFileName)) {
                File.Delete(configuration.BulkFileName);
            }
            var fileStream = File.OpenWrite(configuration.BulkFileName);
            await result.CopyToAsync(fileStream);

            configuration.CurrentBulk = configuration.LastAvailableBulk;
        }
    }
}
