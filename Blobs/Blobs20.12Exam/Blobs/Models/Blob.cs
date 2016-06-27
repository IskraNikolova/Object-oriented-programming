namespace Blobs.Models
{
    using Blobs.Interfaces;

    public abstract class Blob : IBlob
    {     
        private string name;
        private int health;
        private int damage;
        public readonly int InitialHealth;
        public readonly int InitialDamage;

        protected Blob(string name, int health, int damage)
        {
            InitialHealth = health / 2;
            InitialDamage = damage;
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.IsActivateBehavior = false;
            this.IsFirst = false;
        }
        public string Name { get; private set; }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this.health = value;

                if (value <= this.InitialHealth )
                {
                    this.IsActivateBehavior = true;
                }
            }            
        }

        public int Damage {
            get
            {
                return this.damage;
            }
            set
            {
                if (value < InitialDamage)
                {
                    value = InitialDamage;
                }

                this.damage = value;
            }
        }

        public bool IsActivateBehavior { get; private set; }

        public bool IsFirst { get; set; }

        public abstract void ActivateBehavior();

        public virtual void Attack(IBlob target)
        {
            target.Health -= this.Damage;
        }

        public override string ToString()
        {
            string result = this.Health > 0
                ? $"Blob {this.Name}: {this.Health} HP, {this.Damage} Damage"
                : $"Blob {this.Name} KILLED";
            return result;
        }
    }
}
