using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());

            double price;
            if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = number * 2.70;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    case "apple":
                        price = number * 1.25;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    case "orange":
                        price = number * 0.90;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    case "grapefruit":
                        price = number * 1.60;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    case "kiwi":
                        price = number * 3.00;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    case "pineapple":
                        price = number * 5.60;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    case "grapes":
                        price = number * 4.20;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = number * 2.50;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    case "apple":
                        price = number * 1.20;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    case "orange":
                        price = number * 0.85;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    case "grapefruit":
                        price = number * 1.45;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    case "kiwi":
                        price = number * 2.70;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    case "pineapple":
                        price = number * 5.50;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    case "grapes":
                        price = number * 3.85;
                        Console.WriteLine("{0:f2}", price);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
