using System;

namespace Special_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    for (int h = 1; h <= k; h++)
                    {
                        if (i % 2 == 0 && h % 2 == 0 && (j == 2 || j == 3 || j == 5 || j == 7))
                        {
                            Console.WriteLine($"{i} " + $"{j} " + $"{h}");
                        }
                       
                    }
                }
            }

            
        }
    }
}
