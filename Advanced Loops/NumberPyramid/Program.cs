using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int line = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int a = 1; a <= i; a++)
                {
                    Console.Write(line + " ");
                    line++;
                    if (line > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (line > n)
                {
                    break;
                }
            }

            
        }
    }
}
