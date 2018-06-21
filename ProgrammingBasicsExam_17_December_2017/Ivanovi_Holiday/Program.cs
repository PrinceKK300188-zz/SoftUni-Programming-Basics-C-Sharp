using System;

namespace Ivanovi_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int vacantionDays = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string transport = Console.ReadLine();

            double vacantionPrice = 0; 
            switch (destination)
            {
                case "Miami":
                    if (vacantionDays <= 10)
                    {
                        vacantionPrice = (2 * 24.99 + 3 * 14.99) * vacantionDays;
                    }
                    else if (vacantionDays > 11 && vacantionDays <= 15)
                    {
                        vacantionPrice = (2 * 22.99 + 3 * 11.99) * vacantionDays;
                    }
                    else if (vacantionDays > 15)
                    {
                        vacantionPrice = (2 * 20.00 + 3 * 10.00) * vacantionDays;
                    }
                    break;
                case "Canary Islands":
                    if (vacantionDays <= 10)
                    {
                        vacantionPrice = (2 * 32.50 + 3 * 28.50) * vacantionDays;
                    }
                    else if (vacantionDays > 11 && vacantionDays <= 15)
                    {
                        vacantionPrice = (2 * 30.50 + 3 * 25.60) * vacantionDays;
                    }
                    else if (vacantionDays > 15)
                    {
                        vacantionPrice = (2 * 28.00 + 3 * 22.00) * vacantionDays;
                    }
                    break;
                case "Philippines":
                    if (vacantionDays <= 10)
                    {
                        vacantionPrice = (2 * 42.99 + 3 * 39.99) * vacantionDays;
                    }
                    else if (vacantionDays > 11 && vacantionDays <= 15)
                    {
                        vacantionPrice = (2 * 41.00 + 3 * 36.00) * vacantionDays;
                    }
                    else if (vacantionDays > 15)
                    {
                        vacantionPrice = (2 * 38.50 + 3 * 32.40) * vacantionDays;
                    }
                    break;
            }
            vacantionPrice = vacantionPrice * 1.25;

            double transportCost = 0.0;
            switch (transport)
            {
                case "train":
                    transportCost = 2 * 22.30 + 3 * 12.50;
                    break;
                case "bus":
                    transportCost = 2 * 45.00 + 3 * 37.00;
                    break;
                case "airplane":
                    transportCost = 2 * 90.00 + 3 * 68.50;
                    break;
            }

            double totalCost = vacantionPrice + transportCost;

            Console.WriteLine($"{totalCost:F3}");

        }
    }
}
