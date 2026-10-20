namespace ClothingStoreSystem.Models.Colors;

/// Semantic color assignments for the clothing store interface.
public sealed class Pallets
{
    /// The main brand color, HEX #2563EB.
    public readonly ColorToken Primary;

    /// A supporting middle tone of the brand color.
    public readonly ColorToken Secondary;

    /// Dark shade used for primary text.
    public readonly ColorToken TextPrimary;

    /// Muted tone used for secondary text.
    public readonly ColorToken TextSecondary;

    /// Brand tone used for primary borders.
    public readonly ColorToken BorderPrimary;

    /// Lighter tint used for secondary borders.
    public readonly ColorToken BorderSecondary;

    /// Very light tint used for the primary interface background.
    public readonly ColorToken BackgroundPrimary;

    /// White used for secondary interface backgrounds.
    public readonly ColorToken BackgroundSecondary;

    public Pallets()
    {
        var tints = new Tints();
        var tones = new Tones();
        var shades = new Shades();

        // Brand Blue is the single primary brand color from the supplied color tables.
        Primary = new ColorToken("brand-blue", 0, "#2563EB", "Main clothing store brand color");
        Secondary = tones.mutedBlue;

        TextPrimary = shades.veryDarkBlue;
        TextSecondary = tones.blueGray;
        BorderPrimary = tones.steelBlue;
        BorderSecondary = tints.lightCornflowerBlue;
        BackgroundPrimary = tints.veryPaleBlue;
        BackgroundSecondary = tints.white;
    }
}
