using System;
using ConZoleCommon;

namespace ConZole.Plugin.SystemInfo
{
    public class SystemInfoCommand : IPluginCommand
    {
        public string Name
        {
            get { return "system"; }
        }

        public void Execute(HostContext host, string[] parameters)
        {
            Console.WriteLine("System info:");
            Console.WriteLine("----------------");
            Console.WriteLine($"OS: {Environment.OSVersion}");
            Console.WriteLine($".NET {Environment.Version}");
        }
    }
}
