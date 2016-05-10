namespace WinterIsComing.Models.Spells
{
    public class Stomp : Spell
    {
        private const int DefaultEnergyCost = 10;

        public Stomp(int damage) 
            : base(damage, DefaultEnergyCost)
        {
        }
    }
}
