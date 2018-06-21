using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int kuku = 2;
            int starsEvenTop = 2;
            int starsOddTop = 1;
            int bau = 0;
            for (int i = 0; i < n-kuku ; i++)
            {
                if (n % 2 == 0)
                {
                    for (int a = 0; a < (n - starsEvenTop) /2; a++)
                    {
                        Console.Write("-");
                    }

                    for (int a = 0; a < starsEvenTop; a++)
                    {
                        Console.Write("*");
                       
                    }
                    


                    for (int a = (n - starsEvenTop)/ 2; a > 0; a--)
                    {
                        Console.Write("-");
                    }
                    starsEvenTop += 2;
                }
                else
                {
                    for (int a = 0; a < (n - starsOddTop) / 2; a++)
                    {
                        Console.Write("-");
                    }

                    for (int a = 0; a < starsOddTop; a++)
                    {
                        Console.Write("*");

                    }



                    for (int a = (n - starsOddTop) / 2; a > 0; a--)
                    {
                        Console.Write("-");
                    }
                    starsOddTop += 2;
                }
                Console.WriteLine();
                kuku++;
                bau++;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 0; i < n-bau-1; i++)
            {
                Console.Write("|");
                for (int a = 0; a < n-2; a++)
                {
                    Console.Write("*");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}     
