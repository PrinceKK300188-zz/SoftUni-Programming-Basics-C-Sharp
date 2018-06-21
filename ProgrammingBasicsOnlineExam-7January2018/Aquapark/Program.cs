using System;

namespace Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int spendHours = int.Parse(Console.ReadLine());
            int person = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double dayPrice = 10.50;
            double nightPrice = 8.4;
            double finalPrice = 0;
            if (month == "june" || month == "july" || month == "august")
            {
                dayPrice = 12.60;
                nightPrice = 10.20;
            }
            if (person >= 4)
            {
                dayPrice = dayPrice - (dayPrice / 10.0);
                nightPrice = nightPrice - (nightPrice / 10.0);
            }

            if (spendHours >= 5)
            {
                dayPrice = dayPrice / 2.0;
                nightPrice = nightPrice / 2.0;
            }
            switch (dayOrNight.ToLower())
            {
                case "day":

                    finalPrice = spendHours * dayPrice * person;
                    Console.WriteLine($"Price per person for one hour: {dayPrice:F2}");
                    break;
                case "night":
                    finalPrice = spendHours * nightPrice * person;
                    Console.WriteLine($"Price per person for one hour: {nightPrice:F2}");
                    break;      
            }

            Console.WriteLine($"Total cost of the visit: {finalPrice:F2}");
        }
    }
}
