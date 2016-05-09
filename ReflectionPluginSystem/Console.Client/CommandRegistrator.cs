using System;
using System.Collections.Generic;
namespace Console.Client
{
    using ConZoleCommon;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public class CommandRegistrator
    {
        Dictionary<string, IPluginCommand> commands;

        public CommandRegistrator(string path)
        {
            commands = new Dictionary<string, IPluginCommand>();
            LoadPluginsFromDirectory(path);
        }

        private void LoadPluginsFromDirectory(string path)
        {
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                if (file.EndsWith(".dll"))
                {
                    this.LoadPluginsFromFile(file);
                }
            }
        }

        private void LoadPluginsFromFile(string file)
        {
            var assembly = Assembly.LoadFile(file);
            var pluginTypes = assembly.GetTypes()
                .Where(type => typeof (IPluginCommand)
                .IsAssignableFrom(type));

            foreach (var type in pluginTypes)
            {
                var insatnce = Activator.CreateInstance(type) as IPluginCommand;
                this.commands.Add(insatnce.Name, insatnce);
            }
        }

        public Dictionary<string, IPluginCommand> GetCommands()
        {
            return this.commands;
        }
    }
}
