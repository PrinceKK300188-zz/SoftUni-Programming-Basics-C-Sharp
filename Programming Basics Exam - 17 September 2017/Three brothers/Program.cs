using System;

namespace Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double father = double.Parse(Console.ReadLine());

            double sum = 1 /(1/first + 1/second + 1/third);
            sum = sum + sum * 15 / 100.0;
            Console.WriteLine($"Cleaning time: {sum:F2}");
            if (sum >= father)
            {
                double rest = sum - father;
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(rest));
            }
            else if (sum < father)
            {
                double rest = father - sum;
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Truncate(rest));

            }
            
        }
    }
}
