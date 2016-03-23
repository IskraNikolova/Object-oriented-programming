namespace Problem2Animals.Animal.Cat
{
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine($"{this.Name} said Mauuuuuuuu!");
        }
    }
}