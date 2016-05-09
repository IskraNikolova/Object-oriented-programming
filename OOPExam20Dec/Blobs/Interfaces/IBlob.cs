namespace Blobs.Interfaces
{
    public interface IBlob : IUpdatable, IAttacker, IDestroyable
    {
        string Name { get; set; }

        bool IsEarlyUpdate { get; set; }

        bool IsUpdatable();
    }
}