namespace WildFarm.Core
{
    using WildFarm.Models;
    using WildFarm.Models.Mammals;
    using WildFarm.Models.Mammals.Felime;

    public class AnimalFactory
    {
        public Animal CreateAnimal(string line)
        {
            string[] args = line.Split();
            string type = args[0];
            string name = args[1];
            double weight = double.Parse(args[2]);
            string leavingRegion = args[3];

            Animal animal = null;
            switch (type)
            {
                case "Cat":
                    string breed = args[4];
                    animal = new Cat(name, weight, leavingRegion, breed);
                    break;
                case "Tiger":
                    animal = new Tiger(name, weight, leavingRegion);
                    break;
                case "Zebra":
                    animal = new Zebra(name, weight, leavingRegion);
                    break;
                case "Mouse":
                    animal = new Mouse(name, weight, leavingRegion);
                    break;
            }

            return animal;
        }
    }
}
