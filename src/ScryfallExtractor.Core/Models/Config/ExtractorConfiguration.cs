namespace ScryfallExtractor.Core.Models.Config
{
    public class ExtractorConfiguration
    {
        public BulkData CurrentBulk { get; set; }
        public BulkData LastAvailableBulk { get; set; }
        public string BulkFileName { get; set; }
        public string OutputFolder { get; set; }
    }
}
