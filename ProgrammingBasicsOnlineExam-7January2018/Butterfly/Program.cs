using System;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countForTop = (4 * n - 8) / 4;
            if (n % 2 != 0)
            {
                countForTop = (4 * n - 8) / 4;
            }
            for (int i = 1; i <= countForTop; i++)
            {
                for (int a = 0; a < i; a++)
                {
                    Console.Write("*\\");
                }

                for (int a = 0; a < (4*n-4) - 4 * i; a++)
                {
                    Console.Write(" ");
                }

                for (int a = 0; a < i; a++)
                {
                    Console.Write("/*");
                }
            Console.WriteLine("");
            }

            //Прост ред
            for (int i = 0; i < (4*n-4) / 2; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("");

            //Средна част
            for (int i = 1; i <= n/2; i++)
            {
                for (int a = 0; a < ((4 * n) - 10) / 2; a++)
                {
                    Console.Write("<"); ;
                }
                Console.Write("*|**|*"); ;
                
                for (int a = 0; a < ((4 * n) - 10) / 2; a++)
                {
                    Console.Write(">"); ;
                }
                Console.WriteLine("");
            }

            
            //Прост ред
            for (int i = 0; i < (4 * n - 4) / 2; i++)
            {
                Console.Write("/\\");
            }
            Console.WriteLine("");

            //Долна част
            for (int i = countForTop; i > 0; i--)
            {
                for (int a = 0; a < i; a++)
                {
                    Console.Write("*/");
                }

                for (int a = 0; a < (4 * n - 4) - 4 * i; a++)
                {
                    Console.Write(" ");
                }

                for (int a = 0; a < i; a++)
                {
                    Console.Write("\\*");
                }
                Console.WriteLine("");
            }

        }
    }
}
