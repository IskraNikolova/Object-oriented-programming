namespace WinterIsComing.Models.Spells
{
    public class Cleave : Spell
    {
        private const int DefaultEnergyCost = 15;

        public Cleave(int damage) 
            : base(damage, DefaultEnergyCost)
        {
        }
    }
}
