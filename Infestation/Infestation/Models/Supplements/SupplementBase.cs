using Infestation.Interfaces;

namespace Infestation.Models.Supplements
{
    public abstract class SupplementBase : ISupplement
    {
        protected SupplementBase()
        {
            this.PowerEffect = PowerEffect;
            this.HealthEffect = HealthEffect;
            this.AggressionEffect = AggressionEffect;
        }

        public int PowerEffect { get; protected set; } 

        public int HealthEffect { get; protected set; }

        public int AggressionEffect { get; protected set; }

        public virtual void ReactTo(ISupplement otherSupplement)
        {           
        }
    }
}
