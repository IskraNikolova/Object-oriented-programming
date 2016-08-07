namespace LambdaCore_Skeleton
{
    using Interfaces;
    using UI;

    public class Program
    {
        public static void Main()
        {  
            IWritter consoleWriter = new ConsoleWriter();
            IReader consoleReader = new ConsoleReader();
            IPowerPlant powerPlant = new PowerPlant(consoleWriter, consoleReader); 
            
            powerPlant.Run();   
        }
    }
}