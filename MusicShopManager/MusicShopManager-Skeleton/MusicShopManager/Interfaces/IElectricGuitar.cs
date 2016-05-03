namespace MusicShop.Interfaces
{
    public interface IElectricGuitar : IGuitar
    {
        int NumberOfAdapters { get; }

        int NumberOfFrets { get; }
    }
}
