using System;

namespace Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double needSum = 0;
            if (gender == "m")
            {
                switch (sport)
                {
                    case "Gym":
                        needSum = 42;
                        break;
                    case "Boxing":
                        needSum = 41;
                        break;
                    case "Yoga":
                        needSum = 45;
                        break;
                    case "Zumba":
                        needSum = 34;
                        break;
                    case "Dances":
                        needSum = 51;
                        break;
                    case "Pilates":
                        needSum = 39;
                        break;
                }
            }
            else if (gender == "f")
            {
                switch (sport)
                {
                    case "Gym":
                        needSum = 35;
                        break;
                    case "Boxing":
                        needSum = 37;
                        break;
                    case "Yoga":
                        needSum = 42;
                        break;
                    case "Zumba":
                        needSum = 31;
                        break;
                    case "Dances":
                        needSum = 53;
                        break;
                    case "Pilates":
                        needSum = 37;
                        break;
                }
            }

            if (age < 20) needSum = needSum * 0.8;

            if (money >= needSum)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${(needSum - money):f2} more.");
            }
  
        }
    }
}
