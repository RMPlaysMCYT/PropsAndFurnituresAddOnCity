using ingot.Core.Behaviour.Entity;
using ingot.Core.Common;

public class RoboticBin : Entity
{
    public override Identifier Identifier => new("pafa_city:robotic_bin");
    public override Dictionary<string, string>? Animations => new()
    {
        ["Idle"] = "controller.animation.robotic_bin_idle",
        ["Open"] = "controller.animation.robotic_bin_open",
        ["Opening"] = "controller.animation.robotic_bin_opening",
        ["Close"] = "controller.animation.robotic_bin_close"
    };

    public override ServerEntityScripts? Scripts =>  new()
    {
        Animate = [
            "Idle",
            "Open",
            "Opening",
            "Close"
        ]
    };
    
}