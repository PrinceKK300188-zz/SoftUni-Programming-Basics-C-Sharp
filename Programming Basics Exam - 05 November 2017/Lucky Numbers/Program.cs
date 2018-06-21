using System;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int p = 1; p <= 9; p++)
                        {
                            if (i+k == j + p && n % (i + k) == 0)
                            {
                                Console.Write($"{i}{k}{j}{p} ");
                            }

                        }
                    }
                }
            }
            
        }
    }
}
