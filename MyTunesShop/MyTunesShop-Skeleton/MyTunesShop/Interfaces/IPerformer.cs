using System.Collections.Generic;

namespace MyTunesShop.Interfaces
{
    public interface IPerformer
    {
        string Name { get; }

        PerformerType Type { get; }

        IList<ISong> Songs { get; }
    }
}
