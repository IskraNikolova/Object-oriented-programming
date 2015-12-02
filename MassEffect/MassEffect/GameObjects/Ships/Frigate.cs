using System;
using System.Text;
using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Frigate : Starship
    {
        private const int FrigateHealth = 60;
        private const int FrigateShields = 50;
        private const int FrigateDamage = 30;
        private const int FrigateFuel = 220;

        private int projectilesFired;

        public Frigate(string name, StarSystem location) 
            : base(name, FrigateHealth, FrigateShields, FrigateDamage, FrigateFuel, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            var attack = new ShieldReaver(this.Damage);
            this.projectilesFired++;

            return attack;
        }

        public override string ToString()
        {
            String output = base.ToString();

            if (this.Health > 0)
            {
                output += $"{Environment.NewLine}-Projectiles fired: {this.projectilesFired}";
            }

            return output;
        }
    }
}
