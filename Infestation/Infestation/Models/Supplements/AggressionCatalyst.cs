namespace Infestation.Models.Supplements
{
    public class AggressionCatalyst : SupplementBase
    {
        private const int DefaultAggressionEffect = 3;

        public AggressionCatalyst()
            : base()
        {
            this.AggressionEffect = DefaultAggressionEffect;
        }
    }
}