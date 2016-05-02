using Infestation.Interfaces;

namespace Infestation.Models.Supplements
{
    public class Weapon : SupplementBase
    { 
        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.PowerEffect = 10;
                this.AggressionEffect = 3;
            }
        }
    }
}
