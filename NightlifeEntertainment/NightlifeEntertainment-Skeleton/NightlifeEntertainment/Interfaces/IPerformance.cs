using System;
using System.Collections.Generic;
using NightlifeEntertainment.Models;
using NightlifeEntertainment.Models.Performances;
using NightlifeEntertainment.Models.Tickets;

namespace NightlifeEntertainment.Interfaces
{
    public interface IPerformance
    {
        string Name { get; }

        decimal BasePrice { get; }
        
        IVenue Venue { get; }

        DateTime StartTime { get; }

        PerformanceType Type { get; }

        IList<ITicket> Tickets { get; }

        void AddTicket(ITicket ticket);

        string SellTicket(TicketType type);
    }
}
