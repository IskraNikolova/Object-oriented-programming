
using System;
using System.Linq;
using System.Reflection;
using Empires.Interfaces;


namespace Empires.Factories
{
    public class BuildingFactory : IBuildingFactory
    {
        public IBuilding CreateBuilding(string buildingType, IResourceFactory resourceFactory, IUnitFactory unitFactory)
        {
            var type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLowerInvariant() == buildingType);

            var building = (IBuilding)Activator.CreateInstance(type, unitFactory, resourceFactory);

            return building;
        }
    }
}
