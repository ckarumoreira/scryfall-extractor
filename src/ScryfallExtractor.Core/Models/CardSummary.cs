using System.Text;

namespace ScryfallExtractor.Core.Models;

public class CardSummary {
    public string Name { get; set; }
    public CardRarity LowestRarity { get; set; }
    public CardRarity HighestRarity { get; set; }
    public string Type { get; set; }
    public ushort Cmc { get; set; }
    public string ManaCost { get; set; }
    public ColorPie ColorIdentity { get; set; }
    public bool IsDigitalOnly { get; set; }
    public string ImageUri { get; set; }

    public static string ExportHeaderToCsv() {
        string[] elements = [
            nameof(Name),
            nameof(LowestRarity),
            nameof(HighestRarity),
            nameof(Type),
            nameof(Cmc),
            nameof(ManaCost),
            nameof(ColorIdentity),
            nameof(IsDigitalOnly),
            nameof(ImageUri)
        ];

        return string.Join("|", elements);
    }

    public string ExportUnitToCsv() {
        string[] elements = [
            Name,
            LowestRarity.ToString(),
            HighestRarity.ToString(),
            Type,
            Cmc.ToString(),
            ManaCost,
            ColorIdentity.ParseToString(),
            IsDigitalOnly.ToString(),
            ImageUri ?? string.Empty
        ];

        return string.Join("|", elements);
    }
}
