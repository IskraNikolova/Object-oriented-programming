using Kermen.Core;

namespace Kermen.Interfaces
{
    public interface IEngine
    {
        IWriter Writer { get; }

        IReader Reader { get; }

        Factory Factory { get; }

        void Run();
    }
}