using System;
using MusicShop.Interfaces;

namespace MusicShop.Models.Articles.Instruments
{
    public class Drums : Instrument, IDrums
    {
        private int width;
        private int height;

        public Drums(string make, string model, decimal price, string color,  int width, int height) 
            : base(make, model, price, color, false)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width must be positive.");
                }

                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The height must be positive.");
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Size: {this.Width}cm x {this.Height}cm\n";
        }
    }
}
