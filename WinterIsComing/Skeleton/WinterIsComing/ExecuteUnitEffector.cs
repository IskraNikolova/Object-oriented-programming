using System.Collections.Generic;
using WinterIsComing.Contracts;

namespace WinterIsComing
{
    public class ExecuteUnitEffector : IUnitEffector
    {
        private const int RaisedHealthPoints = 50;
        public void ApplyEffect(IEnumerable<IUnit> units)
        {
            foreach (var unit in units)
            {
                unit.HealthPoints += RaisedHealthPoints;
            }
        }
    }
}
