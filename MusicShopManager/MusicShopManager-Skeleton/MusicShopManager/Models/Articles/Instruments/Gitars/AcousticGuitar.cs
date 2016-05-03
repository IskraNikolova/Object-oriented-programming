using System.Text;
using MusicShop.Interfaces;

namespace MusicShop.Models.Articles.Instruments.Gitars
{
    public class AcousticGuitar : Guitar, IAcousticGuitar
    {
        public AcousticGuitar(string make, 
            string model, 
            decimal price, 
            string color,
            string bodyWood, 
            string fingerBoardWood,
            bool caseIncluded,
            StringMaterial stringMaterial) 
            : base(make, 
                  model, 
                  price, 
                  color,
                  false, 
                  bodyWood, 
                  fingerBoardWood)
        {
            this.CaseIncluded = caseIncluded;
            this.StringMaterial = stringMaterial;
        }

        public bool CaseIncluded { get; }

        public StringMaterial StringMaterial { get; }

        public override string ToString()
        {
            string yesOrNo = this.CaseIncluded ? "yes" : "no";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Case included: {yesOrNo}");
            sb.AppendLine($"String material: {this.StringMaterial}");

            return base.ToString() + sb;
        }
    }
}
