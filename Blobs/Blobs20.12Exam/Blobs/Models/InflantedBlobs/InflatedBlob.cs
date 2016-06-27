namespace Blobs.Models.InflantedBlobs
{
    using Blobs.Interfaces;

    public abstract class InflatedBlob : Blob
    {
        private const int GainsHealth = 50;
        private const int LosesHealth = 10;

        protected InflatedBlob(string name, int health, int damage) 
            : base(name, health, damage)
        {
        }

        public override void ActivateBehavior()
        {
            if (IsActivateBehavior)
            {
                if (!this.IsFirst)
                {
                    this.Health += GainsHealth;
                    this.IsFirst = true;
                }
                else
                {
                    this.Health -= LosesHealth;
                }
            }
        }
    }
}
