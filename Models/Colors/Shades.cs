namespace ClothingStoreSystem.Models.Colors;

/// Brand Blue mixed with black
public sealed class Shades
{
    /// Royal blue: 90% Brand Blue + 10% black.
    public readonly ColorToken royalBlue = new("brand-blue-shade-10", 10, "#2159D4", "90% Brand Blue + 10% black");

    /// Deep blue: 80% Brand Blue + 20% black.
    public readonly ColorToken deepBlue = new("brand-blue-shade-20", 20, "#1E4FBC", "80% Brand Blue + 20% black");

    /// Dark blue: 70% Brand Blue + 30% black.
    public readonly ColorToken darkBlue = new("brand-blue-shade-30", 30, "#1A45A4", "70% Brand Blue + 30% black");

    /// Navy blue: 60% Brand Blue + 40% black.
    public readonly ColorToken navyBlue = new("brand-blue-shade-40", 40, "#163B8D", "60% Brand Blue + 40% black");

    /// Deep navy: 50% Brand Blue + 50% black.
    public readonly ColorToken deepNavy = new("brand-blue-shade-50", 50, "#123276", "50% Brand Blue + 50% black");

    /// Dark navy: 40% Brand Blue + 60% black.
    public readonly ColorToken darkNavy = new("brand-blue-shade-60", 60, "#0F285E", "40% Brand Blue + 60% black");

    /// Midnight blue: 30% Brand Blue + 70% black.
    public readonly ColorToken midnightBlue = new("brand-blue-shade-70", 70, "#0B1E47", "30% Brand Blue + 70% black");

    /// Very dark blue: 20% Brand Blue + 80% black.
    public readonly ColorToken veryDarkBlue = new("brand-blue-shade-80", 80, "#07142F", "20% Brand Blue + 80% black");

    /// Almost black: 10% Brand Blue + 90% black.
    public readonly ColorToken almostBlack = new("brand-blue-shade-90", 90, "#040A17", "10% Brand Blue + 90% black");

    /// Pure black: 100% shade endpoint.
    public readonly ColorToken black = new("brand-blue-shade-100", 100, "#000000", "Pure black");
}
