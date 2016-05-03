using MusicShop.Models;

namespace MusicShop.Interfaces
{
    public interface IAcousticGuitar : IGuitar
    {
        bool CaseIncluded { get; }

        StringMaterial StringMaterial { get; }
    }
}
