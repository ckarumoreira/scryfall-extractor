using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScryfallExtractor.Core.Models;

namespace ScryfallExtractor.Core.Services {
    public interface IScryfallSourceUpdateService {
        Task<bool> IsSourceBulkUpToDate(ExtractorConfiguration configuration);
        Task UpdateSourceBulk(ExtractorConfiguration configuration);
    }
}
