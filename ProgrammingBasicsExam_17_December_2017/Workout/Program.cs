using System;

namespace Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double kilometers = double.Parse(Console.ReadLine());

            double sumKm = kilometers;
            for (int i = 0; i < days; i++)
            {
                int kmDayGrow = int.Parse(Console.ReadLine());
                kilometers *= 1 + kmDayGrow / 100.0;
                sumKm += kilometers;
            }


            if (sumKm < 1000)
            {
                double neededKm = Math.Ceiling(1000 - sumKm);
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {neededKm} more kilometers");
            }
            else
            {
                double overKm = Math.Ceiling(sumKm - 1000);
                Console.WriteLine($"You've done a great job running {overKm} more kilometers!");
            }
        }
    }
}
