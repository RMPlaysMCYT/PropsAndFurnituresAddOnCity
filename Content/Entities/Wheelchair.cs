using ingot.Core;
using ingot.Core.Behaviour.Entity;
using ingot.Core.Common;
using ingot.Core.TraitSystem.Traits.Entity;

public class Wheelchair : Entity
{
    public override Identifier Identifier => new("pafa_city:wheelchair");
    public override bool IsSpawnable => true;
    public override bool IsSummonable => true;
    public override ServerEntityScripts? Scripts => new()
    {
        Animate =
        [
            "ride"
        ]
    };
}