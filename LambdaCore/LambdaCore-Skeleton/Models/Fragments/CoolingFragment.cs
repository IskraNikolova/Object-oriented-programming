namespace LambdaCore_Skeleton.Models.Fragments
{
    using Enums;
    using Interfaces;

    public class CoolingFragment
        : BaseFragment
    {
        private const int DefoultMultiplyer = 3;

        public CoolingFragment(string name, int pressureAffection)
            : base(name, FragmentType.Cooling, pressureAffection)
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
                base.PressureAffection = value;
            }
        }

        public override void Action(ICore core)
        {
            if (core.TottalDurability <= 0)
            {
                core.TottalDurability += this.PressureAffection;
            }
        }
    }
}