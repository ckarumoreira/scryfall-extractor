namespace ScryfallExtractor.Core.Models.Input;

[Flags]
public enum ColorPie : byte
{
    None = 0,
    White = 1,
    Black = 2,
    Red = 4,
    Green = 8,
    Blue = 16
}

public static class ColorPieExtensionMethods
{
    public static string ParseToString(this ColorPie item)
    {
        if (item is ColorPie.None)
            return "Colorless";

        string colorPie = string.Empty;

        if (item.HasFlag(ColorPie.White))
            colorPie += 'W';

        if (item.HasFlag(ColorPie.Black))
            colorPie += 'B';

        if (item.HasFlag(ColorPie.Blue))
            colorPie += 'U';

        if (item.HasFlag(ColorPie.Red))
            colorPie += 'R';

        if (item.HasFlag(ColorPie.Green))
            colorPie += 'G';

        return colorPie;
    }
}
