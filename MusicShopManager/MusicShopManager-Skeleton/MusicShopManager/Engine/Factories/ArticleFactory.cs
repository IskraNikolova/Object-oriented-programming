﻿using MusicShop.Interfaces;
using MusicShop.Interfaces.Engine;
using MusicShop.Models;
using MusicShop.Models.Articles;
using MusicShop.Models.Articles.Instruments;
using MusicShop.Models.Articles.Instruments.Gitars;

namespace MusicShop.Engine.Factories
{
    public class ArticleFactory : IArticleFactory
    {
        public IMicrophone CreateMirophone(string make, string model, decimal price, bool hasCable)
        {
            return new Microphone(make, model, price, hasCable);
        }

        public IDrums CreateDrums(string make, string model, decimal price, string color, int width, int height)
        {
            return new Drums(make, model, price, color, width, height);
        }

        public IElectricGuitar CreateElectricGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, int numberOfAdapters, int numberOfFrets)
        {
            return new ElectricGuitar(make, model, price, color, bodyWood, fingerboardWood, numberOfAdapters, numberOfFrets);
        }

        public IAcousticGuitar CreateAcousticGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, bool caseIncluded, StringMaterial stringMaterial)
        {
            return new AcousticGuitar(make, model, price, color, bodyWood, fingerboardWood, caseIncluded, stringMaterial);
        }

        public IBassGuitar CreateBassGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood)
        {
            return new BassGuitar(make, model, price, color, bodyWood, fingerboardWood);
        }
    }
}
