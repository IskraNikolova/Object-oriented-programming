using System;

public class PersonMain
{
    public static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age:");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter email: ");
        string email = Console.ReadLine();

        Person person = new Person(name, age, email);
        Person personWithoutEmail = new Person(name, age);

        Console.WriteLine(person + "\n********************\n" + personWithoutEmail);
    }
}

