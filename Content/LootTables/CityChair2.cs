using ingot.Core.Behaviour.Loot;
using ingot.Core.Common;

public class CityChair2Loot : LootTable
{
    public override Identifier Identifier => "pafa_city:city_chair2";
    public override LootTableCategory Category => LootTableCategory.Blocks;
    public override LootPool[] Pools =>
    [
        new()
        {
            Rolls = 1,
            Entries =
            [
                new ItemLootEntry("pafa_city:city_chair2")
                {
                    Weight = 1,
                    Functions = [new SetCount { Count = new IntRange(1, 2) }]
                }
            ]
        }
    ];
}
