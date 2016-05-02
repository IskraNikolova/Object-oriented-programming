using Infestation.Interfaces;

namespace Infestation.Models.Supplements
{
    public class InfestationSpores : SupplementBase
    {
        public InfestationSpores() 
            : base()
        {
            this.PowerEffect = -1;
            this.AggressionEffect = 20;
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is InfestationSpores)
            {
                this.PowerEffect = 0;
                this.AggressionEffect = 0;
            }
        }
    }
}
