﻿namespace MusicShop.Interfaces
{
    public interface IGuitar : IInstrument
    {
        string BodyWood { get; }

        string FingerboardWood { get; }

        int NumberOfStrings { get; }
    }
}
