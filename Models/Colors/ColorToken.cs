using System.Drawing;
using System.Text.RegularExpressions;

namespace ClothingStoreSystem.Models.Colors;

public sealed class ColorToken
{
    private static readonly Regex HexPattern = new("^#[0-9A-Fa-f]{6}$", RegexOptions.Compiled);

    public readonly string DigitalName;
    public readonly int Percent;
    public readonly string Hex;
    public readonly string Description;
    public readonly Color Color;

    //Constructor 
    internal ColorToken
        (string digitalName, 
         int percent, 
         string hex, 
         string description)
    {
        if (string.IsNullOrWhiteSpace(digitalName))
        {
            throw new ArgumentException("A digital color name is required.", nameof(digitalName));
        }

        if (percent is < 0 or > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(percent), "Color percentages must be between 0 and 100.");
        }

        if (string.IsNullOrWhiteSpace(hex) || !HexPattern.IsMatch(hex))
        {
            throw new ArgumentException("HEX colors must use the #RRGGBB format.", nameof(hex));
        }

        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentException("A color description is required.", nameof(description));
        }

        DigitalName = digitalName;
        Percent = percent;
        Hex = hex.ToUpperInvariant();
        Description = description;
        Color = ColorTranslator.FromHtml(Hex);
    }
}
