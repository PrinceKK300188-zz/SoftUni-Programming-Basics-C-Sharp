using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int kuku = n;
            if (n % 2 == 0)
            {
                kuku = n - 1;
            }

            int leftRight = (n - 1) / 2;
            int mid = n - 2 * leftRight - 2;
            for (int i = 0; i < kuku / 2 + 1; i++)
            {
                for (int a = 0; a < leftRight; a++)
                {
                    Console.Write("-");

                }

                if (n % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    if (i != 0)
                    {
                        Console.Write("*");
                    }
                }


                for (int a = 0; a < mid; a++)
                {
                    Console.Write("-");
                }

                Console.Write("*");

                for (int a = 0; a < leftRight; a++)
                {
                    Console.Write("-");

                }

                Console.WriteLine();
                leftRight--;
                mid += 2;

            }

            for (int i = 0; i < kuku / 2; i++)
            {
                for (int a = leftRight+2; a > 0; a--)
                {
                    Console.Write("-");

                }

                if (n % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    if (i != kuku/2-1)
                    {
                        Console.Write("*");
                    }
                }


                for (int a = mid-4; a > 0; a--)
                {
                    Console.Write("-");
                }

                Console.Write("*");

                for (int a = leftRight+2; a > 0; a--)
                {
                    Console.Write("-");

                }

                Console.WriteLine();
                leftRight++;
                mid -= 2;

            }

        }
    }
}