
using System;

public class Component
{
    private string name;
    private string details;
    private decimal price;

    public Component (string name, decimal price, string details = null)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
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
                throw new ArgumentException("Name can not be null.");
            }
            this.name = value;
        }
    }
    public string Details
    {
        get
        {
            return this.details;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Details can not be null.");
            }
            this.details = value;
        }
    }
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

}

