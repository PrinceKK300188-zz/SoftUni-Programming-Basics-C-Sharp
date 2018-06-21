using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double o = (a * b * c) / 1000.0;
            o = o - procent * o / 100.0;
            Console.WriteLine($"{o:F3}");
        }
    }
}
