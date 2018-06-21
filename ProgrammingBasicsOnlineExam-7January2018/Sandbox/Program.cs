using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double priceSand = double.Parse(Console.ReadLine());
            double priceWood = double.Parse(Console.ReadLine());

            double realSize = a * b;
            double sandSize = (a - 2 * 0.2) * (b - 2 * 0.2);
            double woodSize = realSize - sandSize;
            double sandNeedKg = Math.Truncate(sandSize * 20);
            double woodNeed = Math.Truncate(woodSize / (2.2 * 0.2));



            double sandNeedKgRest = (sandSize * 20) - sandNeedKg;
            double woodNeedRest = (woodSize / (2.2 * 0.2)) - woodNeed;

            if (sandNeedKgRest != 0)
            {
                sandNeedKg += 1;
            }
            if (woodNeedRest != 0)
            {
                woodNeed += 1;
            }
            //Console.WriteLine(sandNeedKg);
            //Console.WriteLine(woodNeed);
            double andSandPrice = sandNeedKg * priceSand;
            double andWoodPrice = woodNeed * priceWood;
            double sum = andSandPrice + andWoodPrice;

            Console.WriteLine($"{sum:F2}");
        }
    }
}
