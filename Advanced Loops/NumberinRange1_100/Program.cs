using System;

namespace NumberinRange1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]: "); 
            double n = double.Parse(Console.ReadLine());

            int kuku = int.MaxValue;
            for (int i = 0; i < kuku; i++)
            {
                if (n > 0 && n <= 100)
                {
                    Console.WriteLine($"The number is: {n}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                    Console.Write("Еnter a number in the range [1...100]: ");
                    n = double.Parse(Console.ReadLine());
                }
            }

            
            
        }
    }
}
