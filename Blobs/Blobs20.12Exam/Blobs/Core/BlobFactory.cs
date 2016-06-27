namespace Blobs.Core
{
    using Blobs.Interfaces;
    using Blobs.Models.AggressiveBlobs;
    using Blobs.Models.InflantedBlobs;

    public class BlobFactory : IFactory
    {
        public IBlob CreateBlob(string name, int health, int damage, string behavior, string attackType)
        {
            IBlob blob = null;

            if (behavior == "Inflated" && attackType == "PutridFart")
            {
                blob = new PutridFartInflatedBlob(name, health, damage);
            }
            else if (behavior == "Inflated" && attackType == "Blobplode")
            {
                blob = new BlobplodeInflatedBlob(name, health, damage);
            }
            else if(behavior == "Aggressive" && attackType == "Blobplode")
            {
                blob = new BlobplodeAggressiveBlob(name, health, damage);
            }
            else if (behavior == "Aggressive" && attackType == "PutridFart")
            {
                blob = new PutridFartAggressiveBlob(name, health, damage);
            }

            return blob;
        }
    }
}
