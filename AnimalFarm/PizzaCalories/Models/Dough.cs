namespace PizzaCalories.Models
{
    using System;
    using PizzaCalories.Enums;

    public class Dough
    {
        private string flourType;
        private string backType;
        private double grams;

        public Dough(string flourType, string backType, double grams)
        {
            this.FlourType = flourType;
            this.BackType =  backType;
            this.Grams = grams;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }

            set
            {
                if (!Enum.IsDefined(typeof (FlourType), value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                   
                this.flourType = value;
            }
        }

        public string BackType
        {
            get
            {
                return this.backType;
            }

            set
            {
                if (!Enum.IsDefined(typeof(BakingTechniqueType), value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.backType = value;
            }
        }

        public double Grams
        {
            get
            {
                return this.grams;
            }

            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.grams = value;
            }
        }
    }
}
