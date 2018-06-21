using System;

namespace Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            //разбиване на числата
            int a4 = a % 10;
            int cc = a / 10;
            int a3 = cc % 10;
            cc = cc / 10;
            int a2 = cc % 10;
            int a1 = cc/10;

            int b4 = b % 10;
            cc = b / 10;
            int b3 = cc % 10;
            cc = cc / 10;
            int b2 = cc % 10;
            int b1 = cc / 10;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int p = 1; p <= 9; p++)
                        {
                            if ((i % 2 != 0 || i == 1) && i >= a1 && i <= b1)
                            {
                                if ((j % 2 != 0 || j == 1) && j >= a2 && j <= b2)
                                {
                                    if ((k % 2 != 0 || k == 1) && k >= a3 && k <= b3)
                                    {
                                        if ((p % 2 != 0 || p == 1) && p >= a4 && p <= b4)
                                        {
                                            Console.Write($"{i}{j}{k}{p} ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
