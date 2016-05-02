﻿using FurnitureManufacturer.Models.Furnitures;

namespace FurnitureManufacturer.Engine.Factories
{
    using System;

    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "wooden";
        private const string Leather = "leather";
        private const string Plastic = "plastic";
        private const string InvalidMaterialName = "Invalid material name: {0}";

        public ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
           var material = GetMaterialType(materialType).ToString();
           return new Table(model, material, price, height, length, width);
        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            var material = GetMaterialType(materialType).ToString();
            return new Chair(model, material, price, height, numberOfLegs, EngineConstants.NormalChairType);
        }

        public IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            var material = GetMaterialType(materialType).ToString();
            return new AdjustableChair(model, material, price, height, numberOfLegs, EngineConstants.AdjustableChairType);
        }

        public IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            var material = GetMaterialType(materialType).ToString();
            return new ConvertibleChair(model, material, price, height, numberOfLegs, EngineConstants.ConvertibleChairType);
        }

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:
                    return MaterialType.Wooden;
                case Leather:
                    return MaterialType.Leather;
                case Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(InvalidMaterialName, material));
            }
        }
    }
}
