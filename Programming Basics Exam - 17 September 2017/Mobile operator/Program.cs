using System;

namespace Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string term = Console.ReadLine();
            string type = Console.ReadLine();
            string net = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());


            double sum = 0;
            switch (type)
            {
                case "Small":
                    if (net.ToLower() == "yes") sum += 5.50;
                    if (term.ToLower() == "one")
                    { 
                        sum = (sum + 9.98) * months;
                    }
                    else if (term.ToLower() == "two")
                    {
                        sum = (sum + 8.58) * months;
                    }
                break;
                case "Middle":
                    if (net.ToLower() == "yes") sum += 4.35;
                    if (term.ToLower() == "one")
                    {
                        sum = (sum + 18.99) * months;
                    }
                    else if (term.ToLower() == "two")
                    {
                        sum = (sum + 17.09) * months;
                    }
                    break;
                case "Large":
                    if (net.ToLower() == "yes") sum += 4.35;
                    if (term.ToLower() == "one")
                    {
                        sum = (sum + 25.98) * months;
                    }
                    else if (term.ToLower() == "two")
                    {
                        sum = (sum + 23.59) * months;
                    }
                    break;
                case "ExtraLarge":
                    if (net.ToLower() == "yes") sum += 3.85;
                    if (term.ToLower() == "one")
                    {
                        sum = (sum + 35.99) * months;
                    }
                    else if (term.ToLower() == "two")
                    {
                        sum = (sum + 31.79) * months;
                    }
                    break;
            }

            if (term.ToLower() == "two")
            {
                sum = sum - sum * 3.75 / 100;
            }
            Console.WriteLine($"{sum:F2} lv.");
        }
    }
}
