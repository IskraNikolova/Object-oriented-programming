using System;
using System.Linq;
using System.Text;
using Empires.Interfaces;

namespace Empires.Core
{
    public class Engine : IRunnable
    {
        private IBuildingFactory buildingFactory;
        private IResourceFactory resourceFactory;
        private IUnitFactory unitFactory;
        private IEmpiresDate data;
        private IInputReader reader;
        private IOutputWriter writer;

        public Engine(IBuildingFactory buildingFactory,
            IResourceFactory resourceFactory,
            IUnitFactory unitFactory,
            IEmpiresDate data, 
            IInputReader reader, 
            IOutputWriter writer)
        {
            this.buildingFactory = buildingFactory;
            this.resourceFactory = resourceFactory;
            this.unitFactory = unitFactory;
            this.data = data;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();
                this.ExecuteCommands(input);
                this.UpdateBuildings();
            }
        }

        private void UpdateBuildings()
        {
            foreach (IBuilding building in this.data.Buildings)
            {
                building.Update();
                if (building.CanProduceResource)
                {
                    var resource = building.ProduceResource();
                    this.data.Resource[resource.ResourceType] += resource.Quantity;
                }

                if (building.CanProduceUnit)
                {
                    var unit = building.ProduceUnit();
                    this.data.AddUnit(unit);
                }
            }
        }

        private void ExecuteCommands(string[] input)
        {
            switch (input[0])
            {
                case "empire-status":
                    this.ExecuteStatusCommand();
                    break;
                case "armistice":
                    Environment.Exit(0);
                    break;
                case "skip":
                    break;
                case "build":
                    this.ExecuteBuildCommand(input[1]);
                    break;
                default:
                    throw new AggregateException("Uknow command.");
            }
        }

        private void ExecuteBuildCommand(string buildingType)
        {
            IBuilding building = this.buildingFactory.CreateBuilding(buildingType, 
                this.resourceFactory, this.unitFactory);

            data.AddBuilding(building);
        }

        private void ExecuteStatusCommand()
        {
            StringBuilder output = new StringBuilder();

            AppendTreasuryMethod(output);
            AppendBuildingInfo(output);
            AppendUnitsInfo(output);

            this.writer.Print(output.ToString().Trim());
        }

        private void AppendUnitsInfo(StringBuilder output)
        {
            output.AppendLine("Units:");
            if (this.data.Units.Any())
            {
                foreach (var unit in this.data.Units)
                {
                    output.AppendLine($"--{unit.Key}: {unit.Value}");
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }

        private void AppendBuildingInfo(StringBuilder output)
        {
            output.AppendLine("Buildings:");
            if (this.data.Buildings.Any())
            {
                foreach (var building in this.data.Buildings)
                {
                    output.AppendLine(building.ToString());
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }

        private void AppendTreasuryMethod(StringBuilder output)
        {
            output.AppendLine("Treasury:");
            foreach (var resource in this.data.Resource)
            {
                output.Append($"--{resource.Key}: {resource.Value}{Environment.NewLine}");
            }
        }
    }
}
