using System;

namespace Eiffel_Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //2 * N + 6
            for (int i = 0; i < n; i++)
            {
                Console.Write(new String('-', (2 * n + 4) / 2));
                Console.Write("**");
                Console.WriteLine(new String('-', (2 * n + 4) / 2));
            }

            for (int i = 0; i < n-3; i++)
            {
                Console.Write(new String('-', (2 * n + 2) / 2));
                Console.Write("****");
                Console.WriteLine(new String('-', (2 * n + 2) / 2));
            }

            Console.Write(new String('-', n));
            Console.Write("******");
            Console.WriteLine(new String('-', n));

            for (int i = 0; i < n - 4; i++)
            {
                Console.Write(new String('-', n));
                Console.Write("**--**");
                Console.WriteLine(new String('-', n));
            }

            for (int i = 0; i < n - 3; i++)
            {
                Console.Write(new String('-', n - 1));
                Console.Write("**----**");
                Console.WriteLine(new String('-', n - 1));
            }

            Console.Write(new String('-', n-2));
            Console.Write("**********");
            Console.WriteLine(new String('-', n-2));

            for (int i = 0; i < n-3; i++)
            {
                Console.Write(new String('-', n - 3 - i));
                Console.Write("**");
                Console.Write(new String('-', 8 + (2 * i)));
                Console.Write("**");
                Console.WriteLine(new String('-', n - 3 - i));
            }

            Console.Write("***");
            Console.Write(new String('-', 2 * n));
            Console.WriteLine("***");
        }
    }
}
