namespace Blobs.Interfaces
{
    public interface IAttacker
    {
        int Damage { get; set; }

        void Attack(IDestroyable destroyBlob);
    }
}