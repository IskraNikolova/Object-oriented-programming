namespace Problem2Laptop_Shop
{
    using System;

    public class Battery
    {
        private string batteryModel;
        private double batteryLife;

        public Battery(string model, double life)
        {
            this.BatteryModel = model;
            this.BatteryLife = life;
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Battery can not be empty!");
                }

                this.batteryModel = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery life can not be negative or null!");
                }

                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            return $"{this.BatteryModel}\nbattery life: {this.BatteryLife} hours";
        }
    }
}