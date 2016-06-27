namespace Blobs.UI
{
    using System;
    using Blobs.Interfaces;

    public class Writer :IWriter
    {
        public void WriteLine(string data)
        {
            Console.WriteLine(data);
        }
    }
}
