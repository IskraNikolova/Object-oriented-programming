namespace LambdaCore_Skeleton.Interfaces
{
    using Collection;
    using Enums;

    public interface ICore
    {
        char Name { get; }

        CoreType CoreType { get; }

        int StartDurability { get; }

        int TottalDurability { get; set; }

        ListStack<IFragment> Fragments { get; }

        bool IsCriticalState { get; }

        void AddFragment(IFragment fragment);
    }
}