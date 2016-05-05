namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Text;
    using System.Collections.Generic;

    public class Toothpaste : Product, IToothpaste
    {
        private string ingredient;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients) 
            : base(name, brand, price, gender)
        {
            this.Ingredients = string.Join(", ", ingredients);
        }
         
        public string Ingredients
        {
            get
            {
                return this.ingredient;
                
            }

            private set
            {
                var ingridientsForValidate = value.Split(',');
                foreach (var i in ingridientsForValidate)
                {
                    Validator.CheckIfStringLengthIsValid(
                        i, 12, 4,
                        string.Format(GlobalErrorMessages.InvalidStringLength, i, 4, 12));
                }

                Validator.CheckIfStringIsNullOrEmpty(
                    value, 
                    string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, value));

                this.ingredient = value;
            }
        }

        public override string Print()
        {
            StringBuilder output = new StringBuilder();
            output.Append($"  * Ingredients: {this.Ingredients}");

            return base.Print() + output;
        }
    }
}
