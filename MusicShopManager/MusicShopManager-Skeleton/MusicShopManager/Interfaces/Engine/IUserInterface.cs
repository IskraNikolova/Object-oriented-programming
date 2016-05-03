using System.Collections.Generic;

namespace MusicShop.Interfaces.Engine
{
    public interface IUserInterface
    {
        IEnumerable<string> Input();

        void Output(IEnumerable<string> output);
    }
}
