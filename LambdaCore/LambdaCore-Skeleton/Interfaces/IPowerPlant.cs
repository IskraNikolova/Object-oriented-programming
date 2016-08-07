namespace LambdaCore_Skeleton.Interfaces
{
    using System.Collections.Generic;
    using Core;

    public interface IPowerPlant
    {
        IWritter Writer { get; }

        IReader Reader { get; }

        ICollection<ICore> Cores { get; }

        Factory Factory { get; }

        ICore SelectedCore { get; }

        int TottalDurability { get; }

        int TottalFragments { get; }

        void Run();

        void AttachFragment(string[] data);

        void DetachFragment();

        void SelectCore(string data);
    }
}