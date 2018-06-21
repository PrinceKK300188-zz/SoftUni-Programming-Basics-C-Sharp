using System;

namespace RhombusofStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int a = 0; a < n-i; a++)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < i; a++)
                {
                    Console.Write("* ");
                }
                for (int a = 0; a < n-i-1; a++)
                {
                    Console.Write(" ");
                    
                }
                Console.WriteLine("");
                //Console.Write("Hello World!");

            }

            for (int i = n-1; i >= 1; i--)
            {
                for (int a = 0; a < n - i; a++)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < i; a++)
                {
                    Console.Write("* ");
                }
                for (int a = 0; a < n - i - 1; a++)
                {
                    Console.Write(" ");

                }
                Console.WriteLine("");
                //Console.Write("Hello World!");

            }

            //Console.WriteLine("Hello World!");
        }
    }
}
