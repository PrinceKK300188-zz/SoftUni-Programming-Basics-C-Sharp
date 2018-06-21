using System;

namespace Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightInKg = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());

            double cost = 0;
            double costPerKg = 0;
            switch (type)
            {
                case "standard":
                    if (weightInKg < 1)
                    {
                        cost = 0.03 * distance;
                    }
                    else if (weightInKg >= 1 && weightInKg <= 10)
                    {
                        cost = 0.05 * distance;
                    }
                    else if (weightInKg >= 11 && weightInKg <= 40)
                    {
                        cost = 0.10 * distance;
                    }
                    else if (weightInKg >= 41 && weightInKg <= 90)
                    {
                        cost = 0.15 * distance;
                    }
                    else if (weightInKg >= 91 && weightInKg <= 150)
                    {
                        cost = 0.20 * distance;
                    }

                    break;
                case "express":
                    if (weightInKg < 1)
                    {
                        costPerKg = 0.8 * 0.03;
                        cost = 0.03 * distance + costPerKg * weightInKg * distance;
                    }
                    else if (weightInKg >= 1 && weightInKg <= 10)
                    {
                        costPerKg = 0.4 * 0.05;
                        cost = 0.05 * distance + costPerKg * weightInKg * distance;
                    }
                    else if (weightInKg >= 11 && weightInKg <= 40)
                    {
                        costPerKg = 0.05 * 0.10;
                        cost = 0.10 * distance + costPerKg * weightInKg * distance;
                    }
                    else if (weightInKg >= 41 && weightInKg <= 90)
                    {
                        costPerKg = 0.02 * 0.15;
                        cost = 0.15 * distance + costPerKg * weightInKg * distance;
                    }
                    else if (weightInKg >= 91 && weightInKg <= 150)
                    {
                        costPerKg = 0.01 * 0.20;
                        cost = 0.20 * distance + costPerKg * weightInKg * distance;
                    }
                    break;
            }
            Console.WriteLine($"The delivery of your shipment with weight of {weightInKg:f3} kg. would cost {cost:f2} lv.");
        }
    }
}
