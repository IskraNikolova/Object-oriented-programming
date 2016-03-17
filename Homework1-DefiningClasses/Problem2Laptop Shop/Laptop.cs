namespace Problem2Laptop_Shop
{
    using System;

    public class Laptop
    {
        private readonly bool isShortVersion;

        private string model;
        private string manufacturer;
        private string processor;
        private int rAM;
        private string graphicsCard;
        private string hDD;
        private string screen;
        private decimal price;

        public Laptop(
            string model, 
            decimal price, 
            string processor, 
            int rAM, 
            string graphicsCard, 
            string hDD, 
            string screen, 
            Battery battery,
            string manufacturer)
        {
            this.Model = model;
            this.Price = price;
            this.Processor = processor;        
            this.RAM = rAM;
            this.GraphicsCard = graphicsCard;
            this.HDD = hDD;
            this.Screen = screen;
            this.Battery = battery;       
            this.Manufacturer = manufacturer;
        }

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
            isShortVersion = true;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException(nameof(value), "Model can not be empty!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException(nameof(value), "Manufacturer can not be empty!");
                }

                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException(nameof(value), "Processor can not be empty!");
                }

                this.processor = value;
            }
        }

        public int RAM
        {
            get
            {
                return this.rAM;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("RAM can not be negative or null!");
                }

                this.rAM = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException(nameof(value), "Graphics card can not be empty!");
                }

                this.graphicsCard = value;
            }
        }

        public string HDD
        {
            get
            {
                return this.hDD;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException(nameof(value), "HDD can not be empty!");
                }

                this.hDD = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException(nameof(value), "Screen can not be empty!");
                }

                this.screen = value;
            }
        }

        public Battery Battery { get; set; }
     
        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price can not be negative or null!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;

            if (!isShortVersion)
            {
                result = $"model: {this.Model}\nmanufacturer: {this.Manufacturer}\nprocessor: " +
                         $"{this.Processor}\nRAM: {this.RAM} GB\ngraphics card: {this.GraphicsCard}\nHDD: {this.HDD}\nscreen: {this.Screen}\n" +
                         $"battery: {this.Battery}\nprice: {this.Price:F2} lv";
            }
            else
            {
                result = $"model: {this.Model}\nprice: {this.Price}";
            }

            return result;
        }
    }
}