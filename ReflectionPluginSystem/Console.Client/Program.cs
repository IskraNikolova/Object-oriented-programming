namespace Console.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ConZoleCommon;

    public class Program
    {
        static Dictionary<string, IPluginCommand> commands = new Dictionary<string, IPluginCommand>();
        public static void Main(string[] args)
        {
            RegisterCommands();
            while (true)
            {
                var userLine = Console.ReadLine();

                if (userLine == "Exit")
                {
                    return;
                }

                var commandParts = userLine.Split();
                var commandName = commandParts[0];

                if (!commands.ContainsKey(commandName))
                {
                    Console.WriteLine("Invalid command!");
                    continue;
                }

                var command = commands[commandName];
                var context = new HostContext();
                command.Execute(context, commandParts.Skip(1).ToArray());
            }

        }

        static void RegisterCommands()
        {
            var commandRegistration = new CommandRegistrator(Environment.CurrentDirectory + @"\Plugins");
            commands = commandRegistration.GetCommands();
        }
    }
}