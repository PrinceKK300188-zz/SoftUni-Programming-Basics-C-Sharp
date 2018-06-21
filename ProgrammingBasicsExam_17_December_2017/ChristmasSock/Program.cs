using System;

namespace ChristmasSock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Първи ред
            Console.Write("|");
            for (int i = 0; i < 2*n; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("|");

            //Втори ред
            Console.Write("|");
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("|");

            //Трети ред
            Console.Write("|");
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("|");

            for (int i = 1; i <= (2*n-3)/2 + 1; i++)
            {
                Console.Write("|");
                for (int a = 0; a < n-i; a++)
                {
                    Console.Write("-");
                }
                for (int a = 2 * i; a > 0; a--)
                {
                    Console.Write("~");
                }
                for (int a = n-i; a > 0; a--)
                {
                    Console.Write("-");
                }
                Console.WriteLine("|");
            }

            for (int i = (2 * n - 3) / 2; i > 0 ; i--)
            {
                Console.Write("|");
                for (int a = 0; a < n - i; a++)
                {
                    Console.Write("-");
                }
                for (int a = 2 * i; a > 0; a--)
                {
                    Console.Write("~");
                }
                for (int a = n - i; a > 0; a--)
                {
                    Console.Write("-");
                }
                Console.WriteLine("|");
            }

            //Долна част
            for (int i = 0; i < n+3; i++)
            {
                double count = n/2;
                //if (n % 2 == 0) count = (n + 3) - 2*i - 1;
                double count2 = n/2 + 2;
                //if (n % 2 == 0) count2 = (n + 3) - 2*i + 3;

                if (i == n + 2)
                {
                    //Последен ред
                    for (int a = 0; a < i; a++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("\\");
                    for (int a = 0; a < 2 * n + 1; a++)
                    {
                        Console.Write("_");
                    }
                    Console.WriteLine(")");
                }
                else if (i == count)
                {
                    for (int a = 0; a < i; a++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("\\");
                    for (int a = 0; a < ((2 * n + 1) - 5) / 2; a++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("MERRY");
                    for (int a = 0; a < ((2 * n + 1) - 5) / 2; a++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine("\\");
                }
                else if (i == count2)
                {
                    for (int a = 0; a < i; a++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("\\");
                    for (int a = 0; a < ((2 * n + 1) - 5) / 2; a++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("X-MAS");
                    for (int a = 0; a < ((2 * n + 1) - 5) / 2; a++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine("\\");
                }
                else
                {
                    for (int a = 0; a < i; a++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("\\");
                    for (int a = 0; a < 2 * n + 1; a++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine("\\");
                }

            }

            //(n+3)
            // 3 - 2 => 6
            // 4 - 3 => 7
            // 5 - 3 => 8
            // 6 - 4 => 9
            // 7 - 4 => 10
            // 8 - 5 => 11
            // 9 - 5 => 12


        }
    }
}
