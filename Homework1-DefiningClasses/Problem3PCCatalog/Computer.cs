
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

public class Computer
{
    private string name;
    private List<Component> components;
    private decimal price;

    public Computer(string name, List<Component> components)
    {
        this.Name = name;
        this.Components = components;
        this.Price = GetSumOfComponents(this.Components);
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
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
        get { return this.price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price can not be negative or null!");
            }
            this.price = value;
        }
    }

    public decimal GetSumOfComponents(List<Component> components)
    {
        return components.Sum(compo => compo.Price);
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

