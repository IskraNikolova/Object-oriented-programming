using Empires.Enums;

namespace Empires.Interfaces
{
    public interface IResource
    {
        ResourceType ResourceType { get; }
        
        int Quantity { get; } 
    }
}