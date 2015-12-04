using System;

namespace Problem1GalacticGPS
{
    public class MainTest
    {
        public static void Main()
        {
            double latitude = 218.037986;
            double longitude = 28.870097;

            Location home = new Location(latitude, longitude, Planet.Earth);
            Console.WriteLine(home);
        }
    }
}
