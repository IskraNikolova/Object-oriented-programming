namespace Empires.Models
{
    using Enums;
    using Interfaces;
    using Buildings;
    using static Enums.ResourceType;

    public class Archery : Building
    {
        private const string ArcheryUnitType = "Archer";
        private const int  ArcheryUnitCycleLength = 3;

        private const ResourceType ArcheryResourceType = Gold;
        private const int ArcheryResourceCycleLength = 2;
        private const int ArcheryResourceQuantity = 5;

        public Archery(IUnitFactory unitFactory, IResourceFactory resourceFactory)
            : base(ArcheryUnitType, ArcheryUnitCycleLength, ArcheryResourceType, 
                  ArcheryResourceCycleLength, ArcheryResourceQuantity,unitFactory, resourceFactory)
        {
        }
    }
}
