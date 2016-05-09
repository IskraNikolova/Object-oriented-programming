
using Blobs.Enums;

namespace Blobs.Models
{
    public class AggressiveBehaviorBlob : Blob
    {
        public AggressiveBehaviorBlob(string name, int health, int damage, AttackType attackType) 
            : base(name, health, damage, attackType)
        {
        }

        public override void Update()
        {
            var result = this.Damage - 5;
            this.Damage = result;
            //if (result >= this.Damage)
            //{
            //    this.Damage = result;
            //}
        }
    }
}
