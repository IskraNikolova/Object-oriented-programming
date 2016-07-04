using System;

namespace WildFarm.Foods
{
    public class Food
    {
        private int quantity;

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Quantity cannot be negative.");
                }
            }
        }
    }
}
