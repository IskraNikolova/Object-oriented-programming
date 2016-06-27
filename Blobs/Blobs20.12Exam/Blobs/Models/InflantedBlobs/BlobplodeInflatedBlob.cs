using Blobs.Interfaces;

namespace Blobs.Models.InflantedBlobs
{
    public class BlobplodeInflatedBlob : InflatedBlob
    {
        public BlobplodeInflatedBlob(string name, int health, int damage) 
            : base(name, health, damage)
        {
        }

        public override void Attack(IBlob targetBlob)
        {
            this.Health -= (this.Health / 2);
            targetBlob.Health -= (this.Damage * 2);
        }
    }
}
