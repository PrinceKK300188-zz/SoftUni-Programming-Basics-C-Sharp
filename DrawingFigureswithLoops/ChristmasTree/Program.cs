using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }

            Console.Write(" | ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine("");
            for (int i = 1; i <= n; i++)
            {
                for (int a = 0; a < n-i; a++)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < i; a++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int a = i; a > 0; a--)
                {
                    Console.Write("*");
                }
                for (int a = n-i; a > 0; a--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}
