namespace LambdaCore_Skeleton.Models.Fragments
{
    using System;
    using Enums;
    using Interfaces;
    using Utils;

    public abstract class BaseFragment : IFragment
    {
        private FragmentType fragmentType;
        private int pressureAffection;

        protected BaseFragment(string name, FragmentType fragmentType, int pressureAffection)
        {
            this.Name = name;
            this.FragmentType = fragmentType;
            this.PressureAffection = pressureAffection;
        }

        public string Name { get; }

        public FragmentType FragmentType
        {
            get
            {
                return this.fragmentType;
            }
            private set
            {
                if (!Enum.IsDefined(this.fragmentType.GetType(), this.fragmentType))
                {
                    throw new ArgumentException(string.Format(
                        Constants.MessageForFailedAttached, 
                        this.Name));
                }

                this.fragmentType = value;
            }
        }

        public virtual int PressureAffection
        {
            get
            {
                return this.pressureAffection;
            }

             set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(
                        Constants.MessageForFailedAttached, 
                        this.Name));
                }

                this.pressureAffection = value;
            }
        }

        public abstract void Action(ICore core);
    }
}