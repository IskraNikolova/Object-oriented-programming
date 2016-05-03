namespace MusicShop.Interfaces
{
    public interface IInstrument : IArticle
    {
       string Color { get; }

       bool IsElectronic { get; }
    }
}
