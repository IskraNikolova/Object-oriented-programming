using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Dreadnought : Starship
    {
        private const int DreadnoughtHealth = 200;
        private const int DreadnoughtShields = 300;
        private const int DreadnoughtDamage = 150;
        private const int DreadnoughtFuel = 700;

        public Dreadnought(string name, StarSystem location) 
            : base(name, DreadnoughtHealth, DreadnoughtShields, DreadnoughtDamage, DreadnoughtFuel, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            return new Laser(this.Damage + (this.Shields/2));
        }

        public override void RespondToAttack(IProjectile attack)
        {
            this.Shields += 50;
            base.RespondToAttack(attack);
            this.Shields -= 50;
        }
    }
}
