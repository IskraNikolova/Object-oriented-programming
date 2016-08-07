namespace LambdaCore_Skeleton.Core
{
    using System;
    using Enums;
    using Interfaces;
    using Models.Cores;
    using Models.Fragments;
    using Utils;

    public class Factory
    {
        public ICore CreateCore(char name, CoreType type, int durability)
        {
            ICore core = null;
            switch (type)
            {
                case CoreType.Para:
                    core = new ParaBaseCore(name, durability);
                    break;
                case CoreType.System:
                    core = new SystemBaseCore(name, durability);
                    break;
                default:
                    throw new ArgumentException(Constants.MessageForFailedCreateCore);
            }

            return core;
        }

        public IFragment CreateFragment(FragmentType fragmentType, string name, int pressureAffection)
        {
            IFragment fragment = null;
            switch (fragmentType)
            {
                case FragmentType.Cooling:
                    fragment = new CoolingFragment(name, pressureAffection);
                    break;
                case FragmentType.Nuclear:
                    fragment = new NuclearFragment(name, pressureAffection);
                    break;
            }

            return fragment;
        }
    }
}
