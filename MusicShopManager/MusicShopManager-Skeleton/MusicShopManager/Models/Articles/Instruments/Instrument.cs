using System.Text;
using MusicShop.Interfaces;

namespace MusicShop.Models.Articles.Instruments
{
    using System;

    public abstract class Instrument : Article, IInstrument
    {
        private string color;

        protected Instrument(string make, string model, decimal price, string color, bool isElectronic) 
            : base(make, model, price)
        {
            this.Color = color;
            this.IsElectronic = isElectronic;
        }

        public string Color
        {
            get
            {
                return this.color;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The color is required.");
                }

                this.color = value;
            }
        }

        public bool IsElectronic { get; }

        public override string ToString()
        {
            string yesOrNo = this.IsElectronic ? "yes" : "no";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nColor: {this.Color}");
            sb.AppendLine($"Electronic: {yesOrNo}");

            return base.ToString() + sb;
        }
    }
}
