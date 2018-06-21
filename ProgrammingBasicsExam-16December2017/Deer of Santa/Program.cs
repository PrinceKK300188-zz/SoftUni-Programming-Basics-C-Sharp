using System;

namespace Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double firstEat = double.Parse(Console.ReadLine());
            double secondEat = double.Parse(Console.ReadLine());
            double thirdEat = double.Parse(Console.ReadLine());


            double sumneedFood = days * (firstEat + secondEat + thirdEat);
            if (food >= sumneedFood)
            {
                double leftFood = food - sumneedFood;
                Console.WriteLine("{0} kilos of food left.", Math.Truncate(leftFood));
            }
            else
            {
                double leftFood = sumneedFood - food;
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(leftFood));
            }
        }
    }
}
