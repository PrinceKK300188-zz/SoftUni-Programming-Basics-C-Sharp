using System;

namespace Ivanovi_Family
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double gift1 = double.Parse(Console.ReadLine());
            double gift2 = double.Parse(Console.ReadLine());
            double gift3 = double.Parse(Console.ReadLine());

            double sumForGifts = gift1 + gift2 + gift3;
            double rest = budjet - sumForGifts;
            rest = rest - rest * 10 /100 ;

            Console.WriteLine($"{rest:F2}");
        }
    }
}
