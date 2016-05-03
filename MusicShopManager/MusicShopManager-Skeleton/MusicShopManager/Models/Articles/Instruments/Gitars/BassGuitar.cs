using MusicShop.Interfaces;

namespace MusicShop.Models.Articles.Instruments.Gitars
{
    public class BassGuitar : Guitar, IBassGuitar
    {
        private const int DefaultNumberOfString = 4;

        public BassGuitar(
            string make, 
            string model,
            decimal price, 
            string color, 
            string bodyWood, 
            string fingerBoardWood) 
            : base(make, model, price, color, true, bodyWood, fingerBoardWood, DefaultNumberOfString)
        {
        }
    }
}
