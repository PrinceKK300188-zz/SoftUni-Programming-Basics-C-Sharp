using System;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int a = 0; a < n; a++)
                {
                    if (a < n - i)
                    {
                        Console.Write(i + a + 1 + " ");
                    }
                    else
                    {
                        Console.Write(2 * n - (i + a + 1) + " ");
                    }

                }
                
                Console.WriteLine("");
            }
            
        }
    }
}
