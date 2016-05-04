namespace MyTunesShop.Interfaces
{
    using System.Collections.Generic;

    public interface IBand : IPerformer
    {
        IList<string> Members { get; }

        void AddMember(string memberName);
    }
}
