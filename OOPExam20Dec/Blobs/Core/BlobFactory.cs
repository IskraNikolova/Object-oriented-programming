namespace Blobs.Core
{
    using Interfaces;
    using Models;
    using Enums;

    public class BlobFactory : IBlobFactory
    {
        public IBlob CreateBlob(string name, int health, int damage, BlobType blopType, AttackType attackType)
        {
            var blob = new InflatedBehaviorBlob(name, health, damage, attackType);
            return blob;
        }
    }
}
