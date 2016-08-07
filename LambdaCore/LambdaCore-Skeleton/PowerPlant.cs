namespace LambdaCore_Skeleton
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Core;
    using Enums;
    using Interfaces;
    using UI;
    using Utils;

    public class PowerPlant : IPowerPlant
    {
        private const int StartedChar = 65;

        private int charNumberIAascci;

        public PowerPlant(IWritter writer, IReader reader)
        {
            this.Writer = new ConsoleWriter();
            this.Reader = new ConsoleReader();
            this.Cores = new List<ICore>();
            this.Factory = new Factory();
            this.charNumberIAascci = StartedChar;
        }

        public IWritter Writer { get; }

        public IReader Reader { get; }

        public ICollection<ICore> Cores { get; private set; }

        public Factory Factory { get; }

        public ICore SelectedCore { get; private set; }

        public int TottalDurability => this.Cores.Sum(c => c.TottalDurability);

        public int TottalFragments => this.Cores.Sum(c => c.Fragments.Count());

        public void Run()
        {
            string input = this.Reader.ReadLine();
            while (input != "System Shutdown!")
            {
                string[] data = input.Split('@');
                string commandName = data[0].Trim(':');
                switch (commandName)
                {
                    case "CreateCore":
                        this.CreateCore(data);
                        break;
                    case "RemoveCore":
                        this.RemoveCore(data);
                        break;
                    case "SelectCore":
                        this.SelectCore(data[1]);
                        break;
                    case "AttachFragment":
                        this.AttachFragment(data);
                        break;
                    case "DetachFragment":
                        this.DetachFragment();
                        break;
                    case "Status":
                        this.PrintStatus();
                        break;
                }

                input = this.Reader.ReadLine();
            }
        }

        public void PrintStatus()
        {
            StringBuilder status = new StringBuilder();
            status.AppendLine("Lambda Core Power Plant Status:");
            status.AppendLine($"Total Durability: {this.TottalDurability}");
            status.AppendLine($"Total Cores: {this.Cores.Count}");
            status.AppendLine($"Total Fragments: {this.TottalFragments}");
            foreach (var core in this.Cores)
            {
                status.AppendLine(core.ToString());
            }

            this.Writer.Write(status.ToString());
        }

        public void DetachFragment()
        {
            if (this.SelectedCore != null &&
                this.SelectedCore.Fragments.Any())
            {
                var fragment = this.SelectedCore.Fragments.Last();
                this.SelectedCore.Fragments.Pop();
                this.Writer.WriteLine(string.Format(
                                                    Constants.MessageForSuccessfullyDetachedFragment,
                    fragment.Name, this.SelectedCore.Name));
            }
            else
            {
                this.Writer.WriteLine(Constants.MessageForFailedDetachedFragment);
            }
        }

        public void AttachFragment(string[] data)
        {
            var type = (FragmentType)Enum.Parse(typeof(FragmentType), data[1]);
            string nameOfFragment = data[2];
            int pressureAffection = int.Parse(data[3]);
            var fragment = this.Factory.CreateFragment(type, nameOfFragment, pressureAffection);
            if (this.SelectedCore != null)
            {
                this.SelectedCore.AddFragment(fragment);

                this.Writer.WriteLine(string.Format(
                    Constants.MessageForSuccessfullyAttached,
                    nameOfFragment,
                    this.SelectedCore.Name));
                    fragment.Action(this.SelectedCore);
            }
            else
            {
                this.Writer.WriteLine(string.Format(
                    Constants.MessageForFailedAttached,
                    nameOfFragment));
            }
        }

        public void SelectCore(string name)
        {
            char selectedCoreName = char.Parse(name);
            var selectedCores = this.Cores
                    .FirstOrDefault(core => core.Name == selectedCoreName);
            this.SelectedCore = selectedCores;
            if (selectedCores != null)
            {
                this.Writer.WriteLine(string.Format(
                    Constants.MessageForCurrentlySelectedCore,
                    selectedCoreName));
            }
            else
            {
                this.Writer.WriteLine(string.Format(
                    Constants.MessageForFailedSelectCore,
                    selectedCoreName));
            }
        }

        public void RemoveCore(string[] data)
        {
            char nameOfRemovedCore = char.Parse(data[1]);
            var removedCore = this.Cores
                     .FirstOrDefault(core => core.Name == nameOfRemovedCore);

            if (removedCore != null)
            {
                this.Cores.Remove(removedCore);
                this.Writer.WriteLine(string.Format(
                    Constants.MessageForSuccessfullyRemovedCore,
                    nameOfRemovedCore));
            }
            else
            {
                this.Writer.WriteLine(string.Format(
                    Constants.MessageForFailedRemovedCore,
                    nameOfRemovedCore));
            }

            if (this.SelectedCore.Name == removedCore.Name)
            {
                this.SelectedCore = null;
            }
        }

        public void CreateCore(string[] data)
        {
            char name = (char)this.charNumberIAascci;
            var type = (CoreType)Enum.Parse(typeof(CoreType), data[1]);
            int durability = int.Parse(data[2]);
            ICore core = this.Factory.CreateCore(name, type, durability);
            this.Cores.Add(core);
            this.Writer.WriteLine(string.Format(Constants.MessageForSuccessfullyCreatedCore, name));
            this.charNumberIAascci++;
        }
    }
}
