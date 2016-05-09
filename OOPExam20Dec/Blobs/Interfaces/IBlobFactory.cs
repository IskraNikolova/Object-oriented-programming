using Blobs.Enums;

namespace Blobs.Interfaces
{
    public interface IBlobFactory
    {
        IBlob CreateBlob(string name, int health, int damage, BlobType blopType, AttackType attackType);
    }
}