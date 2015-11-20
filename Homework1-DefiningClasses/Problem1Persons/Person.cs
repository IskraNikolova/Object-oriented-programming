
using System;

public class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age)
        : this(name, age, null)
    { }

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

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {         
            if (value < 1 || value > 100)
            {
                throw new ArgumentException("Invalid age!");
            }
            this.age = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {           
            if (!string.IsNullOrEmpty(value) && !value.Contains("@"))
            {
                throw new ArgumentException("Invalid email!");
            }
            this.email = value;
        }
    }

    public override string ToString()
    {
        string result = String.Empty;

        result = !string.IsNullOrEmpty(this.Email) ? $"Name: {this.Name}, Age: {this.Age}, Email: {this.Email}" :
                                      $"Name: {this.Name}, Age: {this.Age}, No email";

        return result;
    }
}

