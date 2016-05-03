using System.Collections.Generic;

namespace MusicShop.Interfaces.Engine
{
    public interface ICommand
    {
        string Name { get; }

        IDictionary<string, string> Parameters { get; }
    }
}
