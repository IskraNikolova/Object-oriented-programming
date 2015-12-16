namespace Empires.Interfaces
{
    public interface IScheduledResourceProducer : IResourceProducer
    {
        bool CanProduceResource { get; }
    }
}