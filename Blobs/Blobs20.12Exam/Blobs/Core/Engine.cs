namespace Blobs.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Blobs.Interfaces;
    using Blobs.UI;

    public sealed class Engine : IEngine
    {
        private static readonly Engine SingleInstance = new Engine();
        private readonly IFactory factory;

        public Engine()
        {
            this.factory = new BlobFactory();
            this.Reader = new Reader();
            this.Writer = new Writer();
            this.Blobs = new List<IBlob>();
        }

        public static Engine Instance
        {
            get
            {
                return SingleInstance;
            }
        }

        public int Counter { get; set; }

        public IWriter Writer { get; set; }

        public IReader Reader { get; set; }

        public IList<IBlob> Blobs { get; set; }

        public void Start()
        {
            var commands = this.ReadCommands();
            this.ProcessCommands(commands);
        }

        private void PrintReports()
        {
            foreach (var blob in this.Blobs)
            {
                this.Writer.WriteLine(blob.ToString());
            }
        }

        private void ProcessCommands(IList<ICommand> commands)
        {
            foreach (var command in commands)
            {
                try
                {
                    this.ProcessSingleCommand(command);

                    foreach (var blob in this.Blobs)
                    {
                        blob.ActivateBehavior();
                    }   
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(ex.Message);
                }
            }
        }

        private void ProcessSingleCommand(ICommand command)
        {
            switch (command.Name)
            {
                case "create":
                    string name = command.Parameters[0];
                    int health = int.Parse(command.Parameters[1]);
                    int damage = int.Parse(command.Parameters[2]);
                    string behavior = command.Parameters[3];
                    string attack = command.Parameters[4];
                    IBlob blob = this.factory.CreateBlob(name, health, damage, behavior, attack);
                    this.Blobs.Add(blob);
                    break;
                case "attack":
                    string attackerName = command.Parameters[0];
                    string targetName = command.Parameters[1];
                    IBlob attacker = this.Blobs.First(b => b.Name == attackerName);
                    IBlob target = this.Blobs.First(b => b.Name == targetName);
                    attacker.Attack(target);
                    break;
                case "status":
                    this.PrintReports();
                    break;
            }
        }

        private IList<ICommand> ReadCommands()
        {
            var commands = new List<ICommand>();

            var currentLine = this.Reader.ReadLine();
            while (true)
            {
                var currentCommand = Command.Parse(currentLine);
                if (currentCommand.Name != "pass")
                {
                    commands.Add(currentCommand);
                }

                if (currentCommand.Name == "drop")
                {
                    break;
                }

                currentLine = this.Reader.ReadLine();
            }

            return commands;
        }
    }
}
