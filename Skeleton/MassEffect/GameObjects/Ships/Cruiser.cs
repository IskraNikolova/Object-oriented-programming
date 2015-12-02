using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Cruiser : Starship
    {
        private const int CruiserHealth = 100;
        private const int CruiserShields = 100;
        private const int CruiserDamage = 50;
        private const int CruiserFuel = 300;

        public Cruiser(string name, StarSystem location)
            : base(name, CruiserHealth, CruiserShields, CruiserDamage, CruiserFuel, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            return new PenetrationShell(this.Damage);
        }
    }
}
