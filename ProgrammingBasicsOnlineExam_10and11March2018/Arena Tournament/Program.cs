using System;

namespace Arena_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            string arenaName = Console.ReadLine();
            string day = Console.ReadLine();
            string condition = Console.ReadLine();

            int price = 0;
            double discountPrice = 0;

            if (condition == "Legendary")
            {
                price = 21000;
            }
            else if (condition == "Normal")
            {
                price = 14000;
            }
            else
            {
                price = 7000;
            }

            if (arenaName == "Nagrand" && (day == "Tuesday" || day == "Monday" || day == "Wednesday"))
            {
                discountPrice = price - price * 5.0 / 100.0;
            }
            else if (arenaName == "Gurubashi" && (day == "Tuesday" || day == "Wednesday" || day == "Thursday"))
            {
                discountPrice = price - price * 10.0 / 100.0;
            }
            else if (arenaName == "Dire Maul" && (day == "Friday" || day == "Saturday" || day == "Sunday"))
            {
                discountPrice = price - price * 7.0 / 100.0;
            }
            else
            {
                discountPrice = price;
            }

            double priceForOneItem = discountPrice / 5.0;
            int count = 0;
            double SumLeft = points;

            for (int i = 1; i <= 5; i++)
            {
                if (SumLeft - priceForOneItem > 0)
                {
                    SumLeft = SumLeft - priceForOneItem;
                    count++;
                }
                else
                {
                    break;
                }
            }

            if (count == 5)
            {
                Console.WriteLine($"Items bought: {count}");
                Console.WriteLine($"Arena points left: {SumLeft}");
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine($"Items bought: {count}");
                Console.WriteLine($"Arena points left: {SumLeft}");
                Console.WriteLine("Failure!");
            }
        }
    }
}
