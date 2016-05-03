using MusicShop.Interfaces;

namespace MusicShop.Models.Articles
{
    public class Microphone : Article, IMicrophone
    {
        public Microphone(string make, string model, decimal price, bool hasCable) 
            : base(make, model, price)
        {
            this.HasCable = hasCable;
        }

        public bool HasCable { get; }

        public override string ToString()
        {
            string yesOrNo = this.HasCable ? "yes" : "no";

            return base.ToString() + $"\nCable: {yesOrNo}\n";
        }
    }
}
