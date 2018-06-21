using System;

namespace Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //int number = 0;
            for (int number = 0; number <= n; )
            {
                number = number * 2 + 1;
                if (number <= n)
                {
                    Console.WriteLine(number);
                }

                
            }
            
        }
    }
}
