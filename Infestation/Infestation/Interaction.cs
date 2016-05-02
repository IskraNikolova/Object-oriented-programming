﻿using Infestation.Models.Units;

namespace Infestation
{
    public class Interaction
    {
        public Interaction(UnitInfo sourceUnitInfo, UnitInfo targetUnitInfo, InteractionType type)
        {
            this.SourceUnit = sourceUnitInfo;
            this.TargetUnit = targetUnitInfo;
            this.InteractionType = type;
        }

        public const Interaction PassiveInteraction = null;

        public UnitInfo SourceUnit { get; private set; }

        public UnitInfo TargetUnit { get; private set; }

        public InteractionType InteractionType { get; private set; }
    }
}
