using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int lastFibo = 0;
            int fiboOne = 0;
            if (n == 0)
            {
                lastFibo = 1;
            }
            int fiboTwo = 1;
            
            for (int i = 0; i < n; i++)
            {
                if (n == 0 || n == 1)
                {
                    lastFibo = 1;
                    break;
                }
                else
                {
                    int fiboThree = fiboOne + fiboTwo;
                    fiboOne = fiboTwo;
                    fiboTwo = fiboThree;
                    lastFibo = fiboThree;
                }
            }

            Console.WriteLine(lastFibo);


        }
    }
}
