using System;
using System.Text;
using MusicShop.Interfaces;

namespace MusicShop.Models.Articles.Instruments.Gitars
{
    public class ElectricGuitar : Guitar, IElectricGuitar
    {
        private int numberOfFrets;
        private int numberOfAdapters;

        public ElectricGuitar(
            string make, 
            string model, 
            decimal price, 
            string color,
            string bodyWood, 
            string fingerBoardWood, 
            int numberOfAdapters,
            int numberOfFrets) 
            : base(make, model, price, color, true, bodyWood, fingerBoardWood)
        {
            this.NumberOfAdapters = numberOfAdapters;
            this.NumberOfFrets = numberOfFrets;
        }

        public int NumberOfAdapters
        {
            get
            {
                return this.numberOfAdapters;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of adapters must be positive.");
                }

                this.numberOfAdapters = value;
            }
        }

        public int NumberOfFrets
        {
            get
            {
                return this.numberOfFrets;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of frets must be positive.");
                }

                this.numberOfFrets = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Adapters: {this.NumberOfAdapters}");
            sb.AppendLine($"Frets: {this.NumberOfFrets}");

            return base.ToString() + sb;
        }
    }
}
