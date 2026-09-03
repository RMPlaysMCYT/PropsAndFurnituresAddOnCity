using ingot.Core.Behaviour.Block;
using ingot.Core.Common;

namespace PropsAndFurnituresAddOnCity.Content.Blocks;

public class CityChair1 : Block
{
    public override Identifier Identifier => "pafa_city:city_chair1";
    public override string? DisplayName => "City Chair";
    public override string? ResourceTexture => "pafa_city_city_chair1";
    public override string? Sound => "wood";
    public override Enums.CatalogueCategory Category => Enums.CatalogueCategory.Construction;
    public override MaterialInstances MaterialInstances => new()
    {
        All = new MaterialInstance(
            "citychair1",
            MaterialInstance.RenderMethods.AlphaTest,
            Path.Combine(AppContext.BaseDirectory, "Data", "citychair1.png"))
    };
    public override string? Geometry => "minecraft:geometry.pafacity_citychair";
}
