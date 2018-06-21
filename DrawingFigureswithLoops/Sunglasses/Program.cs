using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 2*n; i++)
            {
                Console.Write("*");
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write(" ");
            }

            for (int i = 1; i <= 2*n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("*");
                for (int a = 0; a < 2 * n-2; a++)
                {
                    Console.Write("/");
                }

                Console.Write("*");
                if ((n -1)/ 2 == i)
                {
                    for (int x = 0; x < n; x++)
                    {
                        Console.Write("|");
                    }
                }
                else
                {
                    for (int x = 0; x < n; x++)
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("*");
                for (int a = 0; a < 2 * n - 2; a++)
                {
                    Console.Write("/");
                }

                Console.Write("*");
                Console.WriteLine();
            }

            for (int i = 1; i <= 2*n; i++)
            {
                Console.Write("*");
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write(" ");
            }

            for (int i = 1; i <= 2*n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

