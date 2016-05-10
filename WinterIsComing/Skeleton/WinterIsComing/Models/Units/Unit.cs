using System;
using System.Runtime.Remoting;
using System.Security.Policy;
using System.Text;
using WinterIsComing.Contracts;

namespace WinterIsComing.Models.Units
{
    public abstract class Unit : IUnit
    {
        private const int MinRangeValue = 1;
        private const int MaxRangeValue = 5;

        private int healthPoints;
        private string name;
        private int range;
        private int attackPoints;
        private int defencePoints;
        private int energyPoints;

        protected Unit(
            UnitType type, 
            string name, 
            int x, 
            int y, 
            int attackPoints, 
            int healthPoints, 
            int defencePoints, 
            int energyPoints,
            int range)
        {
            this.Type = type;
            this.Name = name;
            this.X = x;
            this.Y = y;
            this.AttackPoints = attackPoints;
            this.HealthPoints = healthPoints;
            this.DefensePoints = defencePoints;
            this.EnergyPoints = energyPoints;
            this.Range = range;
        }

        public UnitType Type { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int Range
        {
            get
            {
                return this.range;
            }

            protected set
            {
                if (value < MinRangeValue || value > MaxRangeValue)
                {
                    throw new ArgumentException($"Range must be between[{MinRangeValue}...{MaxRangeValue}].");
                }

                this.range = value;
            }
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Attack points must be positive.");
                }

                this.attackPoints = value;
            }
        }

        public int HealthPoints { get; set; }


        public int DefensePoints
        {
            get
            {
                return this.defencePoints;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Defence points must be positive.");
                }

                this.defencePoints = value;
            }
        }

        public int EnergyPoints
        {
            get
            {
                return this.energyPoints;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Energy points must be positive.");
                }

                this.energyPoints = value;
            }
        }

        public ICombatHandler CombatHandler { get; protected set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($">{this.Name} - {this.Type} at ({this.X},{this.Y})");

            if (this.HealthPoints <= 0)
            {               
                output.Append("(Dead)");
            }
            else
            {
                output.AppendLine($"-Health points = {this.HealthPoints}");
                output.AppendLine($"-Attack points = {this.AttackPoints}");
                output.AppendLine($"-Defense points = {this.DefensePoints}");
                output.AppendLine($"-Energy points = {this.EnergyPoints}");
                output.Append($"-Range = {this.Range}");
            }
            
            return output.ToString();
        }
    }
}