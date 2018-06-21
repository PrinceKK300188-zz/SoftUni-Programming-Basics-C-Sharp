using System;

namespace RectangleofNxNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int y = 0; y < n; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
