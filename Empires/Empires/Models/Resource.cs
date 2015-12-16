
using Empires.Enums;
using Empires.Interfaces;

namespace Empires.Models
{
    public class Resource : IResource
    {
        public Resource(ResourceType resourceType, int quantity)
        {
            ResourceType = resourceType;
            Quantity = quantity;
        }

        public ResourceType ResourceType { get; }
        public int Quantity { get; }
    }
}
