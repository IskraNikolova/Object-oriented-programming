namespace NightlifeEntertainment.Models.Tickets
{
    using NightlifeEntertainment.Interfaces;

    public class RegularTicket : Ticket
    {
        public RegularTicket(IPerformance performance)
            : base(performance, TicketType.Regular)
        {
        }
    }
}
