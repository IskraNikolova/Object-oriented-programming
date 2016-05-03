using System.Globalization;
using System.Threading;
using MusicShop.Engine;

namespace MusicShop
{
    public class MusicShopManagerProgram
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            MusicShopEngine.Instance.Start();
        }
    }
}
