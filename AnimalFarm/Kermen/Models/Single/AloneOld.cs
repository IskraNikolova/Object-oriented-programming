namespace Kermen.Models.Single
{
    public class AloneOld : Home
    {
        public AloneOld(decimal profit) 
            : base(profit)
        {
            this.CountOfRooms = 1;
            this.RoomsElectricityCost = 15;
        }
    }
}
