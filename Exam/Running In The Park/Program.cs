using System;

namespace Running_In_The_Park
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalMinutes = 0;
            double totalDistance = 0;
            for (int i = 0; i < n; i++)
            {
                int time = int.Parse(Console.ReadLine());
                double distance = double.Parse(Console.ReadLine());
                string mesure = Console.ReadLine();

                totalMinutes += time;
                if (mesure == "m")
                {
                    distance = distance / 1000;
                }
                totalDistance += distance;
            }

            Console.WriteLine($"He ran {totalDistance:f2}km for {totalMinutes} minutes and burned {totalMinutes*20} calories.");
        }
    }
}
