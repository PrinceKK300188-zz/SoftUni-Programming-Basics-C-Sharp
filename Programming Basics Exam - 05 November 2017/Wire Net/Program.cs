using System;

namespace Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            int with = int.Parse(Console.ReadLine());
            int leight = int.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double priceFor1m = double.Parse(Console.ReadLine());
            double weightFor1m = double.Parse(Console.ReadLine());

            double totalLeight = 2 * (with + leight);
            double totalPrice = priceFor1m * totalLeight;
            double plosht = totalLeight * height;
            double totalweight = plosht * weightFor1m;

            Console.WriteLine($"{totalLeight}");
            Console.WriteLine($"{totalPrice:F2}");
            Console.Write($"{totalweight:f3}");
        }
    }
}
