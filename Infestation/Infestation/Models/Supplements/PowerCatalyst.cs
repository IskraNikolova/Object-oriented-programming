namespace Infestation.Models.Supplements
{
    public class PowerCatalyst : SupplementBase
    {
        private const int DefaultPowerEffect = 3;

        public PowerCatalyst() 
            : base()
        {
            this.PowerEffect = DefaultPowerEffect;
        }
    }
}
