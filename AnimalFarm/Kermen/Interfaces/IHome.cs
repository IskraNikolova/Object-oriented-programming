namespace Kermen.Interfaces
{
    public interface IHome
    {
        int Population { get; }

        decimal Profit { get; }

        decimal CountOfRooms { get; }

        int RoomsElectricityCost { get; }

        bool IsAbleToPay { get;  }

        decimal Consumption { get; }

        void Bill();

        void PaySalary();
    }
}