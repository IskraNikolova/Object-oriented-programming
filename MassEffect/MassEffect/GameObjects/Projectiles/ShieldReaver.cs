﻿using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Projectiles
{
    public class ShieldReaver : Projectile
    {
        public ShieldReaver(int damage)
            : base(damage)
        {
        }

        public override void Hit(IStarship ship)
        {
            ship.Health -= this.Damage;
            ship.Shields -= this.Damage*2;
        }
    }
}
