using ingot.Core.Behaviour.Loot;
using ingot.Core.Common;
public class Table1Loot : LootTable
{
    public override Identifier Identifier => "pafa_city:table1";
    public override LootTableCategory Category => LootTableCategory.Blocks;
    public override LootPool[] Pools =>
    [
        new()
        {
            Rolls = 1,
            Entries =
            [
                new ItemLootEntry("pafa_city:city_chair1")
                {
                    Weight = 1,
                    Functions = [new SetCount { Count = new IntRange(1, 2) }]
                }
            ]
        }
    ];
}
