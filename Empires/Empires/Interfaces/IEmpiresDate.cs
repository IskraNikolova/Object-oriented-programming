using System.Collections.Generic;
using Empires.Enums;

namespace Empires.Interfaces
{
    public interface IEmpiresDate
    {
        IEnumerable<IBuilding> Buildings { get; }

        void AddBuilding(IBuilding building);

        IDictionary<string, int> Units { get; }

        void AddUnit(IUnit unit);

        IDictionary<ResourceType, int> Resource { get; }
    }
}