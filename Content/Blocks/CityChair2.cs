using ingot.Core.Behaviour.Block;
using ingot.Core.Common;

public class CityChair2 : Block
{
    public override Identifier Identifier => "pafa_city:city_chair2";
    public override string? DisplayName => "City Chair 2";
    public override string? ResourceTexture => "pafa_city_city_chair2";
    public override string? Sound => "wood";
    public override Enums.CatalogueCategory Category => Enums.CatalogueCategory.Construction;
    public override MaterialInstances MaterialInstances => new()
    {
        All = new MaterialInstance(
            "pafa_city_city_chair2",
            MaterialInstance.RenderMethods.AlphaTest,
            Path.Combine(AppContext.BaseDirectory, "Data", "citychair2.png"))
    };
    public override string? Geometry => "geometry.pafacity_citychair";
}
