using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            int number = int.MaxValue;
            int SumDigits = 0;

            for (int i = 0; i < number; i++)
            {
                SumDigits = SumDigits + (int)(n % 10);
                n = n / 10;
                if (n == 0) {
                    break; 
                }
            }
                

            Console.WriteLine(SumDigits);
        }
    }
}
