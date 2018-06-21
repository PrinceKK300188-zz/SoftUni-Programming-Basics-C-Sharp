using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a < (b + c) && b < (a + c) && c < (a + b))
            {
                string output = "";
                if (a == b && b == c)
                {
                    output = "equilateral";
                }
                else if ((a == b && b != c) || (b == c && c != a) || (c == a && a != b))
                {
                    output = "isosceles";
                }
                else
                {
                    output = "scalene";
                }

                if (a - Math.Truncate(a) == 0) a = (int)a;
                if (b - Math.Truncate(b) == 0) b = (int)b;
                if (c - Math.Truncate(c) == 0) c = (int)c;

                Console.WriteLine($"Triangle with sides {a}, {b} and {c} is {output}.");
            }
            else
            {
                if (a - Math.Truncate(a) == 0) a = (int)a;
                if (b - Math.Truncate(b) == 0) b = (int)b;
                if (c - Math.Truncate(c) == 0) c = (int)c;

                Console.WriteLine($"There is no triangle with sides {a}, {b} and {c}.");
            }
            
        }
    }
}
