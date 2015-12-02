using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Projectiles
{
    public class Laser : Projectile
    {
        public Laser(int damage) 
            : base(damage)
        {
        }

        public override void Hit(IStarship ship)
        {
            int diff = this.Damage - ship.Shields;
            ship.Shields -= this.Damage;

            if (diff > 0)
            {
                ship.Health -= diff;
            }           
        }
    }
}
