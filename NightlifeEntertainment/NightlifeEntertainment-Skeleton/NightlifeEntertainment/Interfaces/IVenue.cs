using System.Collections.Generic;
using NightlifeEntertainment.Models;
using NightlifeEntertainment.Models.Performances;

namespace NightlifeEntertainment.Interfaces
{
    public interface IVenue
    {
        string Name { get; }

        string Location { get; }

        int Seats { get; }

        IList<PerformanceType> AllowedTypes { get; }
    }
}
