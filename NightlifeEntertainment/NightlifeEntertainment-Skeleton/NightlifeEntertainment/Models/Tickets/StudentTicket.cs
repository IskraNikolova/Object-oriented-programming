namespace NightlifeEntertainment.Models.Tickets
{
    using NightlifeEntertainment.Interfaces;

    public class StudentTicket : Ticket
    {
        public StudentTicket(IPerformance performance)
            : base(performance, TicketType.Student)
        {
        }

        protected override decimal CalculatePrice()
        {
            var price = base.CalculatePrice();
            price *= 0.80m;

            return price;
        }
    }
}
