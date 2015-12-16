namespace Empires.Interfaces
{
    public interface IBuildingFactory
    {
        IBuilding CreateBuilding(string buildingType, IResourceFactory resourceFactory, IUnitFactory unitFactory);
    }
}