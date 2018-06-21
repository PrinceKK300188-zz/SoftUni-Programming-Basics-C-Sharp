using System;

namespace Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new String('_', (n + 4) / 2));
            Console.Write("^");
            Console.WriteLine(new String('_', (n + 4) / 2));

            Console.Write(new String('_', (n + 2) / 2));
            Console.Write("/|\\");
            Console.WriteLine(new String('_', (n + 2) / 2));

            int count = n / 2;
            if (n == 4) count = n / 2 + 1;

            for (int i = 0; i < count; i++)
            {
                Console.Write(new String('_', n / 2 - i));
                Console.Write("/");
                Console.Write(new String('.', i));
                Console.Write("|||");
                Console.Write(new String('.', i));
                Console.Write("\\");
                Console.WriteLine(new String('_', n / 2 - i));
            }

            if (n != 4)
            {
                Console.Write(new String('_', (n - 4) / 2));
                Console.Write("/..|||..\\");
                Console.WriteLine(new String('_', (n - 4) / 2));
            }

            Console.Write(new String('_', (n - 2) / 2));
            Console.Write("/.|||.\\");
            Console.WriteLine(new String('_', (n - 2) / 2));

            for (int i = 0; i < n; i++)
            {
                Console.Write(new String('_', (n + 2) / 2));
                Console.Write("|||");
                Console.WriteLine(new String('_', (n + 2) / 2));
            }
            Console.Write(new String('_', (n + 2) / 2));
            Console.Write("~~~");
            Console.WriteLine(new String('_', (n + 2) / 2));

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new String('_', n / 2 - i));
                Console.Write("//");
                Console.Write(new String('.', i));
                Console.Write("!");
                Console.Write(new String('.', i));
                Console.Write("\\\\");
                Console.WriteLine(new String('_', n / 2 - i));
            }

        }

    }
}
