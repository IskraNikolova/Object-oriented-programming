using System;
using System.Text;
using MusicShop.Interfaces;

namespace MusicShop.Models.Articles.Instruments.Gitars
{
    public abstract class Guitar : Instrument, IGuitar
    {
        private string bodyWood;
        private string fingerboardWood;

        protected Guitar(string make, string model, decimal price, string color, bool isElectronic, string bodyWood, string fingerBoardWood, int numberOfStrings = 6)
            : base(make, model, price, color, isElectronic)
        {
            this.BodyWood = bodyWood;
            this.FingerboardWood = fingerBoardWood;
            this.NumberOfStrings = numberOfStrings;
        }

        public string BodyWood
        {
            get
            {
                return this.bodyWood;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The body wood is required.");
                }

                this.bodyWood = value;
            }
        }

        public string FingerboardWood
        {
            get
            {
                return this.fingerboardWood;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The fingerboard wood is required.");
                }

                this.fingerboardWood = value;
            }
        }

        public int NumberOfStrings { get; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Strings: {this.NumberOfStrings}");
            output.AppendLine($"Body wood: {this.BodyWood}");
            output.AppendLine($"Fingerboard wood: {this.FingerboardWood}");

            return base.ToString() + output;
        }
    }
}
