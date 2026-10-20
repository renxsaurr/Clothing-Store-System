namespace ClothingStoreSystem.Models.Colors;

/// Brand Blue mixed with white
public sealed class Tints
{
    /// Royal blue: 90% Brand Blue + 10% white.
    public readonly ColorToken royalBlue = new("brand-blue-tint-10", 10, "#3B73ED", "90% Brand Blue + 10% white");

    /// Bright cornflower blue: 80% Brand Blue + 20% white.
    public readonly ColorToken brightCornflowerBlue = new("brand-blue-tint-20", 20, "#5182EF", "80% Brand Blue + 20% white");

    /// Cornflower blue: 70% Brand Blue + 30% white.
    public readonly ColorToken cornflowerBlue = new("brand-blue-tint-30", 30, "#6692F1", "70% Brand Blue + 30% white");

    /// Light cornflower blue: 60% Brand Blue + 40% white.
    public readonly ColorToken lightCornflowerBlue = new("brand-blue-tint-40", 40, "#7CA1F3", "60% Brand Blue + 40% white");

    /// Soft blue: 50% Brand Blue + 50% white.
    public readonly ColorToken softBlue = new("brand-blue-tint-50", 50, "#92B1F5", "50% Brand Blue + 50% white");

    /// Powder blue: 40% Brand Blue + 60% white.
    public readonly ColorToken powderBlue = new("brand-blue-tint-60", 60, "#A8C1F7", "40% Brand Blue + 60% white");

    /// Pale blue: 30% Brand Blue + 70% white.
    public readonly ColorToken paleBlue = new("brand-blue-tint-70", 70, "#BED0F9", "30% Brand Blue + 70% white");

    /// Ice blue: 20% Brand Blue + 80% white.
    public readonly ColorToken iceBlue = new("brand-blue-tint-80", 80, "#D3E0FB", "20% Brand Blue + 80% white");

    /// Very pale blue: 10% Brand Blue + 90% white.
    public readonly ColorToken veryPaleBlue = new("brand-blue-tint-90", 90, "#E9EFFD", "10% Brand Blue + 90% white");

    /// Pure white: 100% tint endpoint.
    public readonly ColorToken white = new("brand-blue-tint-100", 100, "#FFFFFF", "Pure white");
}
