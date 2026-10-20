namespace ClothingStoreSystem.Models.Colors;

/// Brand Blue mixed with medium gray
public sealed class Tones
{
    /// Royal blue: 90% Brand Blue + 10% gray.
    public readonly ColorToken royalBlue = new("brand-blue-tone-10", 10, "#2E66E0", "90% Brand Blue + 10% gray");

    /// Deep blue: 80% Brand Blue + 20% gray.
    public readonly ColorToken deepBlue = new("brand-blue-tone-20", 20, "#3769D6", "80% Brand Blue + 20% gray");

    /// Muted royal blue: 70% Brand Blue + 30% gray.
    public readonly ColorToken mutedRoyalBlue = new("brand-blue-tone-30", 30, "#406CCB", "70% Brand Blue + 30% gray");

    /// Steel blue: 60% Brand Blue + 40% gray.
    public readonly ColorToken steelBlue = new("brand-blue-tone-40", 40, "#496FC0", "60% Brand Blue + 40% gray");

    /// Muted blue: 50% Brand Blue + 50% gray.
    public readonly ColorToken mutedBlue = new("brand-blue-tone-50", 50, "#5272B6", "50% Brand Blue + 50% gray");

    /// Slate blue: 40% Brand Blue + 60% gray.
    public readonly ColorToken slateBlue = new("brand-blue-tone-60", 60, "#5C74AB", "40% Brand Blue + 60% gray");

    /// Blue gray: 30% Brand Blue + 70% gray.
    public readonly ColorToken blueGray = new("brand-blue-tone-70", 70, "#6577A0", "30% Brand Blue + 70% gray");

    /// Slate gray: 20% Brand Blue + 80% gray.
    public readonly ColorToken slateGray = new("brand-blue-tone-80", 80, "#6E7A95", "20% Brand Blue + 80% gray");

    /// Cool gray: 10% Brand Blue + 90% gray.
    public readonly ColorToken coolGray = new("brand-blue-tone-90", 90, "#777D8B", "10% Brand Blue + 90% gray");

    /// Pure medium gray: 100% tone endpoint.
    public readonly ColorToken gray = new("brand-blue-tone-100", 100, "#808080", "Pure medium gray");
}
