namespace LambdaCore_Skeleton.Models.Cores
{
    using System;
    using System.Linq;
    using System.Text;
    using Collection;
    using Enums;
    using Fragments;
    using Interfaces;
    using Utils;

    public abstract class BaseCore : ICore
    {
        private int startDurability;
        private int tottalDurability;
        private CoreType coreType;

        protected BaseCore(char name, CoreType coreType, int startDurability)
        {
            this.Name = name;
            this.CoreType = coreType;
            this.StartDurability = startDurability;
            this.TottalDurability = this.StartDurability;
            this.Fragments = new ListStack<IFragment>();
        }

        public char Name { get; }

        public CoreType CoreType
        {
            get { return this.coreType; }
            private set
            {
                if (!Enum.IsDefined(this.coreType.GetType(), this.coreType))
                {
                    throw new ArgumentException(Constants.MessageForFailedCreateCore);
                }

                this.coreType = value;
            }
        }

        public virtual int StartDurability
        {
            get
            {
                return this.startDurability;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Constants.MessageForFailedCreateCore);
                    
                }

                this.startDurability = value;
            }
        }

        public int TottalDurability { get; set; }

        public ListStack<IFragment> Fragments { get; }

        public bool IsCriticalState => this.Fragments.Any(f => f is NuclearFragment);

        public void AddFragment(IFragment fragment)
        {
            this.Fragments.Push(fragment);
        }

        public override string ToString()
        {
            string status = this.IsCriticalState ? "CRITICAL" : "NORMAL";
            StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Core {this.Name}:");
                sb.AppendLine($"####Durability: {this.TottalDurability}");
                sb.Append($"####Status: {status}");

            return sb.ToString();
        }
    }
}
