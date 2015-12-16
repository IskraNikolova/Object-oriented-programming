using Empires.Enums;

namespace Empires.Interfaces
{
    public interface IResourceFactory
    {
        IResource CreateResource(ResourceType resourceType, int quantity);
    }
}