using System;

public class ExerciseDefiningClasse
{
    public static void Main()
    {
        Dog sharo = new Dog("Sharo", "bolkonka");
        Dog unnamed = new Dog();
        unnamed.Name = "NewName";

        sharo.Bark();
        unnamed.Bark();

    }
}

