using ScryfallExtractor.Core.Models;

namespace ScryfallExtractor.Service.Tests {
    public class ScryfallSourceUpdateServiceTests {
        [Fact]
        public void IsSourceUpToDateTests() {
            var service = new ScryfallSourceUpdateService();

            var config = new ExtractorConfiguration {
                BulkFileName = @"C:\src\scryfall-bulk.json",
                CurrentBulk = new BulkData {
                    DownloadUri = "something",
                    Size = 0,
                    UpdatedAt = new DateTime(2001, 9, 11)
                },
                LastAvailableBulk = null,
                OutputFolder = @"C:\src"
            };

            var isUpToDate = service.IsSourceBulkUpToDate(config);
            
            Assert.False(isUpToDate.Result);

            config.CurrentBulk = null;

            isUpToDate = service.IsSourceBulkUpToDate(config);
            
            Assert.False(isUpToDate.Result);

            config.CurrentBulk = config.LastAvailableBulk;

            isUpToDate = service.IsSourceBulkUpToDate(config);

            Assert.True(isUpToDate.Result);
        }

        [Fact]
        public void DownloadUpdatedBulk() {
            var service = new ScryfallSourceUpdateService();

            var config = new ExtractorConfiguration {
                BulkFileName = @"C:\src\scryfall-bulk.json",
                CurrentBulk = null,
                LastAvailableBulk = null,
                OutputFolder = @"C:\src"
            };

            _ = service.IsSourceBulkUpToDate(config).Result;

            service.UpdateSourceBulk(config).Wait();

            Assert.True(File.Exists(config.BulkFileName));
        }
    }
}