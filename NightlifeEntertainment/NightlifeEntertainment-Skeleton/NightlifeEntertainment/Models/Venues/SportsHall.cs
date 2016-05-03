namespace NightlifeEntertainment.Models.Venues
{
    using System.Collections.Generic;
    using NightlifeEntertainment.Models.Performances;

    public class SportsHall : Venue
    {
        public SportsHall(string name, string location, int numberOfSeats) 
            : base(name, location, numberOfSeats, new List<PerformanceType>() {PerformanceType.Sport, PerformanceType.Concert})
        {
        }
    }
}
