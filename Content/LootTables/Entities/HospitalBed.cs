using ingot.Core.Behaviour.Loot;
using ingot.Core.Common;

namespace MyAddon.Content.LootTables;

public class HospitalBedLoot : LootTable
{
    public override Identifier Identifier => "pafa_city:hospital_bed";
    public override LootTableCategory Category => LootTableCategory.Blocks;
    public override LootPool[] Pools =>
    [
        new()
        {
            Rolls = 1,
            Entries =
            [
                new ItemLootEntry("pafa_city:hospital_bed_spawn_egg")
                {
                    Weight = 1,
                    Functions = [new SetCount { Count = new IntRange(1, 2) }]
                }
            ]
        }
    ];
}
