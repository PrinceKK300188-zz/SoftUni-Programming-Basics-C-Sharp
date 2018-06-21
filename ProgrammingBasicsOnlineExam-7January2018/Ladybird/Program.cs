using System;

namespace Ladybird
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("@   @");
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(" \\_/");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(" / \\");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(" |_|");

            for (int i = 0; i < n; i++)
            {
                for (int a = n-i; a > 1 ; a--)
                {
                    Console.Write(" ");
                }
                Console.Write("/");
                for (int a = 0; a < i; a++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                for (int a = 0; a < i; a++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");

                Console.WriteLine("");
            }

            for (int i = 0; i < n/2; i++)
            {
                int count = (n - 2) / 2;
                int insideCount = ((n - 2) / 2) + 1;
                if (n % 2 == 0)
                {
                    insideCount = (n - 2) / 2;
                }
                Console.Write("|");
                for (int a = 0; a < count; a++)
                {
                    Console.Write(" ");
                }
                Console.Write("@");
                for (int a = 0; a < insideCount; a++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                for (int a = 0; a < insideCount; a++)
                {
                    Console.Write(" ");
                }
                Console.Write("@");
                for (int a = 0; a < count; a++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.WriteLine("");
            }
            if (n>2)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    for (int a = 0; a < i; a++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("\\");

                    for (int a = n - i; a > 1; a--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    for (int a = n - i; a > 1; a--)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("/");
                    for (int a = 0; a < i; a++)
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine("");
                }
            }


            for (int i = 0; i < n-(n/2); i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.Write("^");
            }
            Console.Write("|");
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("^");
            }
            for (int i = 0; i < n - (n / 2); i++)
            {
                Console.Write(" ");
            }

        }
    }
}
