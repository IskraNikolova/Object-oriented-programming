namespace LambdaCore_Skeleton.Interfaces
{
    using Enums;

    public interface IFragment
    {
        string Name { get; }

        FragmentType FragmentType { get; }

        int PressureAffection { get; }

        void Action(ICore core);
    }
}