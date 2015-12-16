
using System;
using System.Collections.Generic;
using Empires.Enums;
using Empires.Interfaces;

namespace Empires.Core
{
    public class EmpiresDate : IEmpiresDate
    {
        private readonly ICollection<IBuilding> buldings = new List<IBuilding>();

        public EmpiresDate()
        {
            this.Resource = new Dictionary<ResourceType, int>();
            this.Units = new Dictionary<string, int>();
            this.InitResources();
        }

        public IEnumerable<IBuilding> Buildings => this.buldings;

        public IDictionary<ResourceType, int> Resource { get; }

        public IDictionary<string, int> Units { get;}

        public void AddBuilding(IBuilding building)
        {
            if (building == null)
            {
                throw new ArgumentException(nameof(building));
            }
            this.buldings.Add(building);
        }
    
        public void AddUnit(IUnit unit)
        {
            if (unit == null)
            {
                throw new ArgumentException(nameof(unit));
            }

            var unitType = unit.GetType().Name;

            if (!this.Units.ContainsKey(unitType))
            {
                this.Units.Add(unitType, 0);
            }
            this.Units[unitType]++;
        }

        private void InitResources()
        {
            foreach (ResourceType resourceType in Enum.GetValues(typeof(ResourceType)))
            {
                this.Resource.Add(resourceType, 0);
            }
        }


    }
}
