using System.Collections.Generic;
using NightlifeEntertainment.Models.Performances;

namespace NightlifeEntertainment.Models.Venues
{
    public class Opera : Venue
    {
        public Opera(string name, string location, int numberOfSeats) 
            : base(name, location, numberOfSeats, new List<PerformanceType>() {PerformanceType.Opera, PerformanceType.Theatre})
        {
        }
    }
}
