namespace Blobs.Interfaces
{
    public interface IFactory
    {
        IBlob CreateBlob(string name, int health, int damage, string behavior, string attackType);
    }
}