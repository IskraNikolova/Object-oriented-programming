namespace Problem3PCCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    public class Computer
    {
        private string name;

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be null.");
                }

                this.name = value;
            }
        }

        public List<Component> Components { get; set; }

        public decimal Price
        {
            get
            {
                decimal price = this.Components.Sum(compo => compo.Price);

                return price;
            }
        }

        public override string ToString()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");

            var result = this.Components.Select(component => this.Components != null ?
                $"{component.Name}: {component.Details} {component.Price:F2}lv.\n" : 
                $"{component.Name} {component.Price:F2}lv.")
                .Aggregate(string.Empty, (current, formatResult) => current + formatResult);

            return $"{this.Name}\n_____________________________\n{result}\n*Total price: {this.Price:F2}lv.";
        }
    }
}