namespace Blobs.Models.AggressiveBlobs
{
    using Blobs.Interfaces;

    public abstract class AggressiveBlob : Blob
    {
        private const int LosesDamage = 5;
        private const int AddDamage = 2;

        protected AggressiveBlob(string name, int health, int damage)
            : base(name, health, damage)
        {   
        }

        public override void ActivateBehavior()
        {
            if (IsActivateBehavior)
            {
                if (!IsFirst)
                {
                    this.Damage *= AddDamage;
                    IsFirst = true;
                }
                else
                {
                    this.Damage -= LosesDamage;
                }
            }       
        }
    }
}
