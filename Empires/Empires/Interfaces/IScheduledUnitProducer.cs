namespace Empires.Interfaces
{
    public interface IScheduledUnitProducer : IUnitProducer
    {
        bool CanProduceUnit { get; }
    }
}