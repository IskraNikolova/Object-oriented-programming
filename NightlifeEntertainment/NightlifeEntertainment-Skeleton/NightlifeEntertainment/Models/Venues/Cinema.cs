namespace NightlifeEntertainment.Models.Venues
{
    using System.Collections.Generic;
    using NightlifeEntertainment.Models.Performances;

    public class Cinema : Venue
    {
        public Cinema(string name, string location, int numberOfSeats)
            : base(name, location, numberOfSeats, new List<PerformanceType> { PerformanceType.Movie, PerformanceType.Concert })
        {
        }
    }
}
