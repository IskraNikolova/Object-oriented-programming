using System;
using System.IO;
using ConZole;

namespace ConsolePlugin.Dir
{
    public class DirCommand : IPluginCommand
    {
        public string Name
        {
            get { return "dir"; }
        }

        public void Execute(HostContext host, string[] parameters)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine("---------------------");
            foreach (var file in Directory.GetFiles(Environment.CurrentDirectory))
            {
                Console.WriteLine(new FileInfo(file).Name);
            }
        }
    }
}
