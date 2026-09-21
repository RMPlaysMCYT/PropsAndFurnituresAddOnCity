using ingot.Core.Behaviour.Loot;
using ingot.Core.Common;

namespace MyAddon.Content.LootTables;

public class CityChair3Loot : LootTable
{
    public override Identifier Identifier => "pafa_city:city_chair3";
    public override LootTableCategory Category => LootTableCategory.Blocks;
    public override LootPool[] Pools =>
    [
        new()
        {
            Rolls = 1,
            Entries =
            [
                new ItemLootEntry("pafa_city:city_chair3")
                {
                    Weight = 1,
                    Functions = [new SetCount { Count = new IntRange(1, 2) }]
                }
            ]
        }
    ];
}
