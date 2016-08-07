namespace LambdaCore_Skeleton.Models.Fragments
{
    using Enums;
    using Interfaces;

    public class NuclearFragment
        : BaseFragment
    {
        private const int DefoultMultiplyer = 2;

        public NuclearFragment(string name, int pressureAffection)
            : base(name, FragmentType.Nuclear, pressureAffection)
        {
        }

        public override int PressureAffection
        {
            get
            {
                return base.PressureAffection;
            }

            set
            {
                base.PressureAffection = value * DefoultMultiplyer;
            }          
        }

        public override void Action(ICore core)
        {
            if (core.TottalDurability > 0)
            {
                core.TottalDurability -= this.PressureAffection;
                if (core.TottalDurability < 0)
                {
                    core.TottalDurability = 0;
                }
            }
        }
    }
}