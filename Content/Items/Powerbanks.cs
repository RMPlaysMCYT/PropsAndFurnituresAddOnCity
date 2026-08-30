using ingot.Core.Behaviour.Item;
using ingot.Core.Common;
using ingot.Core.TraitSystem;
using ingot.Core.TraitSystem.Traits.Item;


public class Powerbanks : Item
{
    public override Identifier Identifier => new("pafa_city:powerbank");
    public override string Texture => "my_item_icon";
    public override int MaxStackSize => 1;
    public override bool AllowOffhand => true;
}