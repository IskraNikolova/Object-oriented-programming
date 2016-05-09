
using Blobs.Enums;

namespace Blobs.Models
{
    public class InflatedBehaviorBlob : Blob
    {
        public InflatedBehaviorBlob(string name, int health, int damage, AttackType attackType)
            : base(name, health, damage, attackType)
        {
        }

        public override void Update()
        {
            var result = this.Health - 10;
            if (this.Health >= 0)
            {
                this.Health = result;
            }     
        }
    }
}
