
using Empires.Enums;
using Empires.Interfaces;

namespace Empires.Models.Buildings
{
    public abstract class Building : IBuilding
    {
        private int cyclesCount = -1;
        private string unitType;
        private int unitCycleLength;
        private ResourceType resourceType;
        private int resourseCycle;
        private int resourceQuantity;
        private IUnitFactory unitFactory;
        private IResourceFactory resourseFactory;

        protected Building(string unitType, 
            int unitCycleLength, 
            ResourceType recourceType,
            int resourceCycle,
            int resourceQuantity,
            IUnitFactory unitFactory,
            IResourceFactory resourceFactory)
        {
            this.unitType = unitType;
            this.unitCycleLength = unitCycleLength;
            this.resourceType = recourceType;
            this.resourseCycle = resourceCycle;
            this.resourceQuantity = resourceQuantity;
            this.unitFactory = unitFactory;
            this.resourseFactory = resourceFactory;
        }

        public bool CanProduceUnit
        {
            get
            {
                bool CanProduceUnit = (this.cyclesCount%this.unitCycleLength == 0) && cyclesCount > 1;
                return CanProduceUnit;
            }
        }

        public bool CanProduceResource
        {
            get
            {
                bool CanProduceResource = (this.cyclesCount % this.resourseCycle == 0) && cyclesCount > 1;
                return CanProduceResource;
            }
        }

        public IResource ProduceResource()
        {
            var resource = this.resourseFactory.CreateResource(this.resourceType, this.resourceQuantity);
            return resource;
        }
      
        public IUnit ProduceUnit()
        {
            var unit = this.unitFactory.CreateUnit(this.unitType);

            return unit;
        }
       
        public void Update()
        {
            this.cyclesCount++;
        }

        public override string ToString()
        {
            int turnsUntilResource = this.resourseCycle - this.cyclesCount % this.resourseCycle;
            int turnsUntilUnit = this.unitCycleLength - this.cyclesCount % this.unitCycleLength;
            var result = $"--{this.GetType().Name}: {this.cyclesCount} turns ({turnsUntilUnit} turns until {this.unitType}, " +
                         $"{turnsUntilResource} turns until {resourceType})";
            return result;
        }
    }
}
