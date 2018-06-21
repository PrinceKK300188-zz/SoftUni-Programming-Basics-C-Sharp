using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;
            double evenSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;
            double oddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    if (input < evenMin || i == 2)
                    {
                        evenMin = input;
                    }
                    if (input > evenMax || i == 2)
                    {
                        evenMax = input;
                    }
                    evenSum += input;
                }
                else
                {
                    if (input < oddMin || i == 1)
                    {
                        oddMin = input;
                    }
                    if (input > oddMax || i == 1)
                    {
                        oddMax = input;
                    }
                    oddSum += input;
                }
            }

            Console.WriteLine("OddSum=" + oddSum);
            if (oddMin == int.MaxValue)
            {
                Console.WriteLine("OddMin=No");
            }
            else
            {
                Console.WriteLine("OddMin=" + oddMin);
            }

            if (oddMax == int.MinValue)
            {
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMax=" + oddMax);
            }
            
            Console.WriteLine("EvenSum=" + evenSum);

            if (evenMin == int.MaxValue)
            {
                Console.WriteLine("EvenMin=No");
            }
            else
            {
                Console.WriteLine("EvenMin=" + evenMin);
            }
            if (evenMax == int.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax=" + evenMax);
            }
        }
    }
}
