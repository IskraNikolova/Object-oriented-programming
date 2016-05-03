namespace NightlifeEntertainment.Models.Venues
{
    using System.Collections.Generic;
    using NightlifeEntertainment.Models.Performances;

    public class ConcertHall : Venue
    {
        public ConcertHall(string name, string location, int numberOfSeats) 
            : base(name, location, numberOfSeats, new List<PerformanceType>()
            {
                PerformanceType.Opera, PerformanceType.Concert, PerformanceType.Theatre
            })
        {
        }
    }
}
