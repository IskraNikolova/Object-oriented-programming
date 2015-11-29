
using System.Collections.Generic;
using System.Linq;
using TheSlum;
using TheSlum.Interfaces;

public class Warrior : Character, IAttack
{
    public Warrior(string id, int x, int y, int healthPoints, int defensePoints, int attackPoints, Team team, int range) 
        : base(id, x, y, healthPoints, defensePoints, team, range)
    {
        this.AttackPoints = attackPoints;
    }

    public int AttackPoints { get; set; }

    public override Character GetTarget(IEnumerable<Character> targetsList)
    {
        var target = targetsList.FirstOrDefault(character => (character.Team != this.Team && character.IsAlive));
        return target;
    }

    protected override void ApplyItemEffects(Item item)
    {
        this.AttackPoints += item.AttackEffect;
        base.ApplyItemEffects(item);
    }

    protected override void RemoveItemEffects(Item item)
    {
        this.AttackPoints -= item.AttackEffect;
        base.RemoveItemEffects(item);
    }

    public override string ToString()
    {
        return base.ToString() + $", Attack: {this.AttackPoints}";
    }
}

