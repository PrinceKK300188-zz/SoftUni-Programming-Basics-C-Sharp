using System;

namespace Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Горна част
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n));
                Console.WriteLine("~ ~ ~");

            }

            Console.WriteLine(new string('=', 3 * n + 5));
            for (int i = 1; i <= n-2; i++)
            {
                //Ако числото минус 1 е нечетно изписвам JAVA на n/2 ред, ако е четно на n/2 + 1
                double count = (n - 1)/ 2 + 1;
                if ((n - 1) % 2 == 0)
                {
                    count = (n -1)/ 2;
                }

                
                if (i == count)
                {
                    Console.Write("|");
                    Console.Write(new string('~', n));
                    Console.Write("JAVA");
                    Console.Write(new string('~', n));
                    Console.Write("|");
                    Console.Write(new string(' ', n - 1));
                    Console.WriteLine("|");
                }
                else
                {
                    Console.Write("|");
                    Console.Write(new string('~', 2 * n + 4));
                    Console.Write("|");
                    Console.Write(new string(' ', n - 1));
                    Console.WriteLine("|");
                }

            }
            Console.WriteLine(new string('=', 3 * n + 5));

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write(new string('\\', 1));
                Console.Write(new string('@', (2 * n + 6) - 2 * i - 2));
                Console.WriteLine(new string('/', 1));

            }
            Console.WriteLine(new string('=', 2 * n + 6));
        }

    }
}
