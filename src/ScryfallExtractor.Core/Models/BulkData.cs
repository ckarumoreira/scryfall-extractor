using System.Text.Json.Serialization;

namespace ScryfallExtractor.Core.Models {
    public class BulkData {
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        
        [JsonPropertyName("size")] 
        public int Size { get; set; }
        
        [JsonPropertyName("download_uri")]
        public string DownloadUri { get; set; }
    }
}
