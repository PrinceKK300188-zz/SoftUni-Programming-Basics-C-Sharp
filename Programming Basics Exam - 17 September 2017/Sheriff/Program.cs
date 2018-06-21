using System;

namespace Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new String('.', (3*n-1)/2));
            Console.Write("x");
            Console.WriteLine(new String('.', (3*n - 1) / 2));
            Console.Write(new String('.', (3 * n - 3) / 2));
            Console.Write("/x\\");
            Console.WriteLine(new String('.', (3 * n - 3) / 2));
            Console.Write(new String('.', (3 * n - 3) / 2));
            Console.Write("x|x");
            Console.WriteLine(new String('.', (3 * n - 3) / 2));

            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.Write(new String('.', (3 * n - 1) / 2 - (n + i)));
                Console.Write(new String('x', n +i));
                Console.Write("|");
                Console.Write(new String('x', n + i));
                Console.WriteLine(new String('.', (3 * n - 1) / 2 - (n + i)));
            }
            for (int i = 0; i <= n/2; i++)
            {
                Console.Write(new String('.', i));
                Console.Write(new String('x', (3 * n - 1) / 2 - i));
                Console.Write("|");
                Console.Write(new String('x', (3 * n - 1) / 2 - i));
                Console.WriteLine(new String('.', i));
            }

            Console.Write(new String('.', (3 * n - 3) / 2));
            Console.Write("/x\\");
            Console.WriteLine(new String('.', (3 * n - 3) / 2));

            Console.Write(new String('.', (3 * n - 3) / 2));
            Console.Write("\\x/");
            Console.WriteLine(new String('.', (3 * n - 3) / 2));

            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.Write(new String('.', (3 * n - 1) / 2 - (n + i)));
                Console.Write(new String('x', n + i));
                Console.Write("|");
                Console.Write(new String('x', n + i));
                Console.WriteLine(new String('.', (3 * n - 1) / 2 - (n + i)));
            }
            for (int i = 0; i <= n / 2; i++)
            {
                Console.Write(new String('.', i));
                Console.Write(new String('x', (3 * n - 1) / 2 - i));
                Console.Write("|");
                Console.Write(new String('x', (3 * n - 1) / 2 - i));
                Console.WriteLine(new String('.', i));
            }

            Console.Write(new String('.', (3 * n - 3) / 2));
            Console.Write("x|x");
            Console.WriteLine(new String('.', (3 * n - 3) / 2));
            Console.Write(new String('.', (3 * n - 3) / 2));
            Console.Write("\\x/");
            Console.WriteLine(new String('.', (3 * n - 3) / 2));
            Console.Write(new String('.', (3 * n - 1) / 2));
            Console.Write("x");
            Console.WriteLine(new String('.', (3 * n - 1) / 2));
        }
    }
}
