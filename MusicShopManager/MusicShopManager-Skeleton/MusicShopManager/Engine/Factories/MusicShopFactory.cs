using MusicShop.Interfaces;
using MusicShop.Interfaces.Engine;
using MusicShop = MusicShop.Models.MusicShop;

namespace MusicShop.Engine.Factories
{
    public class MusicShopFactory : IMusicShopFactory
    {
        public IMusicShop CreateMusicShop(string name)
        {
            return new global::MusicShop.Models.MusicShop(name);
        }
    }
}
