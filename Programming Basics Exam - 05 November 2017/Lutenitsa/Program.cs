using System;

namespace Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            double tomatoes = double.Parse(Console.ReadLine());
            int boxInTruck = int.Parse(Console.ReadLine());
            int jarInBox = int.Parse(Console.ReadLine());

            double lutenica = tomatoes / 5.0;

            Console.WriteLine("Total lutenica: {0} kilograms.", Math.Truncate(lutenica));

            //Брой Буркани
            double jar = lutenica / 0.535;
            double boxes = jar / jarInBox;

            if (boxes > boxInTruck)
            {
                double leftBoxes = boxes - boxInTruck;
                Console.WriteLine("{0} boxes left.", Math.Truncate(leftBoxes));
                Console.WriteLine("{0} jars left.", Math.Truncate(leftBoxes*jarInBox));
            }
            else if (boxes <= boxInTruck)
            {
                double missingBoxes = boxInTruck - boxes;
                Console.WriteLine("{0} more boxes needed.", Math.Truncate(missingBoxes));
                Console.WriteLine("{0} more jars needed.", Math.Truncate(missingBoxes * jarInBox));
            }
        }
    }
}
