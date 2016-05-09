namespace Blobs.Models
{
    using Interfaces;
    using System;
    using Enums;

    public abstract class Blob : IBlob
    {      
        private string name;
        private int health;
        private int damage;
        private AttackType attackType;

        protected Blob(string name, int health, int damage, AttackType attackType)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.AttackType = attackType;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }

                this.name = value;
            }
        }

        public int Health
        {
            get { return this.health; }

            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                this.health = value;
            }
        }

        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                this.damage = value;
            }
        }

        public AttackType AttackType { get; }
        
        public bool IsEarlyUpdate { get; set; }

        public abstract void Update();

        public void Attack(IDestroyable destroyBlob)
        {
            if (this.AttackType == AttackType.PutridFart)
            {
                destroyBlob.Health -= this.Damage;
            }
            else if (this.AttackType == AttackType.Blobplode)
            {
                int halfHealth = this.Health / 2;
                int currentDamage = this.Damage * 2;

                this.Health -= halfHealth;
                destroyBlob.Health -= currentDamage;
            }
        }

        public bool IsUpdatable()
        {
            bool result = false;
            int halfHealth = this.Health / 2;

            if (this.Health <= halfHealth)
            {
                result = true;
                this.IsEarlyUpdate = true;
            }

            return result;
        }
    }
}
 