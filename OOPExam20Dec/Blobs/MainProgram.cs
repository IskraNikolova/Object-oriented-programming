namespace Blobs
{
    using Core;
    using IO;

    public class MainProgram
    {
        public static void Main()
        {
            var blopFactory = new BlobFactory();          
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new Data();

            var engine = new Engine(blopFactory, data, reader, writer);
            engine.Run();

        }
    }
}
