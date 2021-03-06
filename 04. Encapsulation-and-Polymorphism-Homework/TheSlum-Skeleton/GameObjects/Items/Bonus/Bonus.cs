﻿namespace TheSlum.GameObjects.Items.Bonus
{
    using TheSlum.Interfaces;

    public abstract class Bonus : Item, ITimeoutable
    {
        protected Bonus(string id, int healthEffect, int defenseEffect, int attackEffect)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.Timeout = Timeout;
            this.Countdown = Countdown;
            this.HasTimedOut = HasTimedOut;
        }

        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }
    }
}