using System;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
                number = a;
            }

            Console.WriteLine(a);
        }
    }
}
