using System;

public class PersonMain
{
    public static void Main()
    {
        string name = "Mitko";
        int age = 22;
        string email = "mitko@yahoo.com";

        Person person = new Person(name, age, email);
        Person personWithoutEmail = new Person(name, age);

        Console.WriteLine();
        Console.WriteLine(person + "\n********************\n" + personWithoutEmail);

        //string emailTestException = "jkhkjhkjh";
        //Person test = new Person(name, age, emailTestException);
        //Console.WriteLine(test);
    }
}

