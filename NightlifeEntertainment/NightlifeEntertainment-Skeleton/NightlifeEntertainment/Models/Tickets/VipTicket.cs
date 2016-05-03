namespace NightlifeEntertainment.Models.Tickets
{
    using NightlifeEntertainment.Interfaces;

    public class VipTicket : Ticket
    {
        public VipTicket(IPerformance performance) 
            : base(performance, TicketType.VIP)
        {
        }

        protected override decimal CalculatePrice()
        {
            var price = base.CalculatePrice();
            price *= 1.5m;

            return price;
        }
    }
}
