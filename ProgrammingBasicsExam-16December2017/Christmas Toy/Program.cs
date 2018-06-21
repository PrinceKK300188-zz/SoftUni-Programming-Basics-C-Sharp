using System;

namespace Christmas_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int vv = 0;
            int cc = 0;
            //Първи ред
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("-");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");

            //Следващи n/2 реда
            for (int i = 1; i <= n / 2; i++)
            {
                for (int a = 2 * n - 2 * i; a > 0; a--)
                {
                    Console.Write("-");
                }
                for (int a = 0; a < i; a++)
                {
                    Console.Write("*");
                }
                for (int a = 0; a < n + 2 * i; a++)
                {
                    Console.Write("&");
                }

                for (int a = 0; a < i; a++)
                {
                    Console.Write("*");
                }
                for (int a = 2 * n - 2 * i; a > 0; a--)
                {
                    Console.Write("-");
                }
                Console.WriteLine("");
            }

            //Следващи n/2 реда
            cc = n - 1;
            vv = 5 * n - 2 * n - 2;
            if (n % 2 != 0)
            {
                cc = n;
                vv = 5 * n - 2 * n - 4;
            }
            
            for (int i = 0; i < n / 2; i++)
            {
                for (int a = 0; a < cc - i; a++)
                {
                    Console.Write("-");
                }
                Console.Write("**");
                for (int a = 0; a < vv + 2 * i ; a++)
                {
                    Console.Write("~");
                }
                Console.Write("**");
                for (int a = 0; a < cc - i; a++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("");
            }

            //средen ред
            count = n / 2;
            if (n % 2 != 0) count = n / 2 + 1;
            for (int i = 0; i < count; i++)
            {
                Console.Write("-");
            }
            Console.Write("*");
            for (int i = 0; i < 5 * n - 2 * count - 2; i++)
            {
                Console.Write("|");
            }
            Console.Write("*");
            for (int i = 0; i < count; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");


            //Следващи n/2 реда
            cc = n / 2;
            vv = 4 * n - 4;
            if (n % 2 != 0)
            {
                cc = n / 2 + 2;
                vv = 4 * n - 7;
            }
            for (int i = 0; i < n / 2; i++)
            {
                for (int a = 0; a < cc + i; a++)
                {
                    Console.Write("-");
                }
                Console.Write("**");
                for (int a = 0; a < vv - 2 * i; a++)
                {
                    Console.Write("~");
                }
                Console.Write("**");
                for (int a = 0; a < cc + i; a++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("");
            }

            count = n / 2;
            if (n % 2 != 0) count = n / 2;

            //Предпоследни n/2 реда
            cc = n;
            vv = 2 * n;
            if (n % 2 != 0)
            {
                cc = n + 1;
                vv = 2 * n - 1;
            }
            for (int i = 0; i < n / 2; i++)
            {
                for (int a = 0; a < cc + 2 * i; a++)
                {
                    Console.Write("-");
                }
                for (int a = 0; a < count - i; a++)
                {
                    Console.Write("*");
                }
                for (int a = 0; a < vv - 2 * i; a++)
                {
                    Console.Write("&");
                }

                for (int a = 0; a < count - i; a++)
                {
                    Console.Write("*");
                }
                for (int a = 0; a < cc + 2 * i; a++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("");
            }


            //Последен ред
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("-");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
        }
    }
}
