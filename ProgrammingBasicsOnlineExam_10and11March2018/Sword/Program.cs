using System;
using System.Collections.Generic;

namespace Sword
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new String('#', n - 1));
            Console.Write("/^\\");
            Console.WriteLine(new String('#', n - 1));

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new String('#', n - 2 - i));
                Console.Write(".");
                Console.Write(new String(' ', (2 * n) + 1 - 2 * (n - 2 - i) - 2));
                Console.Write(".");
                Console.WriteLine(new String('#', n - 2 - i));
            }

            Dictionary<int, string> soft = new Dictionary<int, string>() { { 0, "S" }, { 1, "O" }, { 2, "F" }, { 3, "T" } };

            for (int i = 0; i < 4; i++)
            {
                int count = n / 2 - 1;
                if (n % 2 != 0)
                {
                    count = n / 2;
                }
                Console.Write(new String('#', count));
                Console.Write("|");
                Console.Write(new String(' ', n / 2));
                Console.Write($"{soft[i]}");
                Console.Write(new String(' ', n / 2));
                Console.Write("|");
                Console.WriteLine(new String('#', count));

            }

            int cs = n - 4;
            if (n == 4)
            {
                cs = n - 3;
            }

            for (int i = 0; i < cs; i++)
            {
                int count = n / 2 - 1;
                if (n % 2 != 0) count = n / 2;
                int cc = n;
                if (n % 2 == 0) cc = n + 1;
                Console.Write(new String('#', count));
                Console.Write("|");
                Console.Write(new String(' ', cc));
                Console.Write("|");
                Console.WriteLine(new String('#', count));
            }

            Dictionary<int, string> uni = new Dictionary<int, string>() { { 0, "U" }, { 1, "N" }, { 2, "I" }};

            for (int i = 0; i < 3; i++)
            {
                int count = n / 2 - 1;
                if (n % 2 != 0)
                {
                    count = n / 2;
                }
                Console.Write(new String('#', count));
                Console.Write("|");
                Console.Write(new String(' ', n / 2));
                Console.Write($"{uni[i]}");
                Console.Write(new String(' ', n / 2));
                Console.Write("|");
                Console.WriteLine(new String('#', count));
            }

            Console.Write("@");
            Console.Write(new String('=', 2*n-1));
            Console.WriteLine("@");

            for (int i = 0; i < n/2; i++)
            {
                int f = n - 4;
                if (n % 2 == 0) f = n - 3;
                Console.Write(new String('#', ((2 * n + 1) - f - 2) / 2));
                Console.Write("|");
                Console.Write(new String(' ', f));
                Console.Write("|");
                Console.WriteLine(new String('#', ((2 * n + 1) - f - 2) / 2));
            }

            int ff = n - 4;
            if (n % 2 == 0) ff = n - 3;
            Console.Write(new String('#', ((2 * n + 1) - ff - 2) / 2));
            Console.Write("\\");
            Console.Write(new String('.', ff));
            Console.Write("/");
            Console.WriteLine(new String('#', ((2 * n + 1) - ff - 2) / 2));
        }
    }
}
