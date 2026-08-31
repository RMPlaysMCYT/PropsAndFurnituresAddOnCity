using ingot.Core.Behaviour.Entity;
using ingot.Core.Common;

public class HospitalBed : Entity
{
    public override Identifier Identifier => new("pafa_city:hospital_bed");
    public override bool IsSpawnable => true;
    public override bool IsSummonable => true;
    public override Dictionary<Identifier, IEntityProperty> Scripts => new()
    {
        [new ("animate")] = new Scripts
        {
            Values = ["ride"]
        }
    }
}