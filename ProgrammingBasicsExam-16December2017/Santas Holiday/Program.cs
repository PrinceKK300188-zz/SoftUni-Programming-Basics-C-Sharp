using System;

namespace Santas_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string rating = Console.ReadLine();

            double bill = 0.0;
            switch (type)
            {
                case "room for one person":
                    bill = (days - 1) * 18.00;
                    break;
                case "apartment":
                    bill = (days - 1) * 25.00;
                    if (days < 10)
                    {
                        bill = bill - bill * 0.3;
                    }
                    else if (days >=10 && days <= 15)
                    {
                        bill = bill - bill * 0.35;
                    }
                    else
                    {
                        bill = bill - bill * 0.5;
                    }
                    break;
                case "president apartment":
                    bill = (days - 1) * 35.00;
                    if (days < 10)
                    {
                        bill = bill - bill * 0.1;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        bill = bill - bill * 0.15;
                    }
                    else
                    {
                        bill = bill - bill * 0.2;
                    }
                    break;
            }

            switch (rating)
            {
                case "positive":
                    bill = bill + bill * 0.25;
                    break;
                case "negative":
                    bill = bill - bill * 0.1;
                    break;
            }
            Console.WriteLine($"{bill:F2}");
        }
    }
}
