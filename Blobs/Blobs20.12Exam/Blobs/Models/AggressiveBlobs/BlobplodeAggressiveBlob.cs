using System;
using Blobs.Interfaces;

namespace Blobs.Models.AggressiveBlobs
{
    public class BlobplodeAggressiveBlob : AggressiveBlob
    {
        public BlobplodeAggressiveBlob(string name, int health, int damage) 
            : base(name, health, damage)
        {
        }

        public override void Attack(IBlob targetBlob)
        {
            this.Health -= this.Health/2;
            targetBlob.Health -= (this.Damage * 2);
        }
    }
}
