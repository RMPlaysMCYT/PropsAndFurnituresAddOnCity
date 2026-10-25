using ingot.Core.Behaviour.Block;
using ingot.Core.Behaviour.Loot;
using ingot.Core.Common;

public class Table1 : Block
{
    public override Identifier Identifier => "pafa_city:table1";
    public override string? DisplayName => "Table 1";
    public override string? ResourceTexture => "pafa_city_table1";
    public override string? Sound => "wood";
    public override LootTable? Loot => new Table1Loot();
    public override Enums.CatalogueCategory Category => Enums.CatalogueCategory.Construction;
    public override MaterialInstances MaterialInstances => new()
    {
        All = new MaterialInstance(
            "pafa_city_city_chair3",
            MaterialInstance.RenderMethods.AlphaTest,
            Path.Combine(AppContext.BaseDirectory, "Data", "citychair2.png"))
    };
    public override string? Geometry => "geometry.pafacity_citychair";


    public override BlockEvents? BlockEvents => new()
    {
        PlayerInteractEvent = ScriptHandler.Inline(
            """
            event.player.sendMessage("Compact dirt feels... dense.");
            """
        )
    };
}
