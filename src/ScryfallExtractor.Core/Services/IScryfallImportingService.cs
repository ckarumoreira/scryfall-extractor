using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScryfallExtractor.Core.Models.Input;

namespace ScryfallExtractor.Core.Services
{
    public interface IScryfallImportingService {
        public IEnumerable<CardInput> ImportCards(Stream cardSourceStream);
        public IEnumerable<CardSummary> ExportCardSummary(IEnumerable<CardInput> cardInput);
    }
}
