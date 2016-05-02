namespace Infestation.Models.Supplements
{
    public class HealthCatalyst : SupplementBase
    {
        private const int DefaultHealthEffect = 3;
        public HealthCatalyst() 
            : base()
        {
            this.HealthEffect = DefaultHealthEffect;
        }
    }
}
