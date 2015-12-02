using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MassEffect.GameObjects.Enhancements;
using MassEffect.GameObjects.Locations;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public abstract class Starship : IStarship
    {
        private readonly IList<Enhancement> enhancements; 

        protected Starship(string name, int health, int shields, int damage, double fuel, StarSystem location)
        {
            this.Name = name;
            this.Health = health;
            this.Shields = shields;
            this.Damage = damage;
            this.Fuel = fuel;
            this.Location = location;
            this.enhancements = new List<Enhancement>();
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Shields { get; set; }
        public int Damage { get; set; }
        public double Fuel { get; set; }
        public StarSystem Location { get; set; }

        public IEnumerable<Enhancement> Enhancements
        {
            get { return this.enhancements; }
        }

        public abstract IProjectile ProduceAttack();

        public virtual void RespondToAttack(IProjectile attack)
        {
            attack.Hit(this);
        }

        public void AddEnhancement(Enhancement enhancement)
        {
            if (enhancement == null)
            {
                throw new ArgumentNullException("Enhancement cannot be null");
            }

            this.enhancements.Add(enhancement);
            this.ApplyEnhancements(enhancement);
        }

        private void ApplyEnhancements(Enhancement enhancement)
        {
            this.Damage += enhancement.DamageBonus;
            this.Fuel += enhancement.FuelBonus;
            this.Shields += enhancement.ShieldBonus;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"--{this.Name} - {this.GetType().Name}");

            if (this.Health <= 0)
            {
                output.Append("(Destroyed)");
            }
            else
            {
                output.AppendLine($"-Location: {this.Location.Name}");
                output.AppendLine($"-Health: {this.Health}");
                output.AppendLine($"-Shields: {this.Shields}");
                output.AppendLine($"-Damage: {this.Damage}");
                output.AppendLine($"-Fuel: {this.Fuel:F1}");

                string enhancmentOutput = "N/A";
                if (this.Enhancements.Any())
                {
                    enhancmentOutput = string.Join(", ", this.Enhancements);
                }           
                output.Append($"-Enhancements: {enhancmentOutput}");
            }
            return output.ToString();
        }
    }
}
