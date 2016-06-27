using Blobs.Models;

namespace Blobs.Interfaces
{
    public interface IBlob
    {
        string Name { get; } 

        int Health { get; set; } 

        int Damage { get; set; }

        void Attack(IBlob target);

        bool IsActivateBehavior { get; }

        void ActivateBehavior();
    }
}