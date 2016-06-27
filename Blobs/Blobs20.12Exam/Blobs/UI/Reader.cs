using System;
using Blobs.Interfaces;

namespace Blobs.UI
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
