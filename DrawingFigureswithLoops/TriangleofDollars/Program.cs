using System;

namespace TriangleofDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int y = 1; y < i; y++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine("$");
            }
        }
    }
}
