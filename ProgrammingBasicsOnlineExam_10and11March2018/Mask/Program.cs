using System;

namespace Mask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n-1; i++)
            {
                Console.Write(new String(' ', n-2-i));
                Console.Write("/");
                Console.Write(new String(' ', i));
                Console.Write("|  |");
                Console.Write(new String(' ', i));
                Console.WriteLine("\\");
            }
            Console.WriteLine(new String('-', 2*n+2));
            Console.Write("|");
            for (int i = 1; i <= 2 * n; i++)
            {
                if (i == n / 2)
                {
                    Console.Write("_");
                }
                else if (i == 2 * n - n / 2 + 1)
                {
                    Console.Write("_");
                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine("|");


            Console.Write("|");
            for (int i = 1; i <= 2*n; i++)
            {
                if (i == n/2)
                {
                    Console.Write("@");
                }
                else if (i == 2*n-n/2+1)
                {
                    Console.Write("@");
                }
                else
                {
                    Console.Write(" ");
                }
                
            }
            Console.WriteLine("|");
            for (int i = 0; i < n/2; i++)
            {
                Console.Write("|");
                Console.Write(new String(' ', 2 * n));
                Console.WriteLine("|");
            }

            Console.Write("|");
            Console.Write(new String(' ', n - 1));
            Console.Write("OO");
            Console.Write(new String(' ', n - 1));
            Console.WriteLine("|");

            Console.Write("|");
            Console.Write(new String(' ', n - 2));
            Console.Write("/  \\");
            Console.Write(new String(' ', n - 2));
            Console.WriteLine("|");

            Console.Write("|");
            Console.Write(new String(' ', n - 2));
            Console.Write("||||");
            Console.Write(new String(' ', n - 2));
            Console.WriteLine("|");

            for (int i = 1; i <= n+1; i++)
            {
                Console.Write(new String('\\', i));
                Console.Write(new String('`', 2*n+2-2*i));
                Console.WriteLine(new String('/', i));
            }
        }
    }
}
