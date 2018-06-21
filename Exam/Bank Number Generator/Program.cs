using System;

namespace Bank_Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            char d = char.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            bool stop = false;
            for (int aa = a; aa < 100; aa++)
            {
                for (char bb = b; bb <= 'Z'; bb++)
                {
                    for (char cc = c; cc <= 'z'; cc++)
                    {
                        for (char dd = d; dd <= 'Z'; dd++)
                        {
                            for (int ee = e; ee >= 10; ee--)
                            {
                                if (aa % 10 == 2 && ee % 10 == 5)
                                {
                                    count++;
                                    if (count == n)
                                    {
                                        Console.WriteLine($"{aa}{bb}{cc}{dd}{ee}");
                                        stop = true;
                                        break;
                                    }
                                }  
                            }
                            if (stop) break;
                        }
                        if (stop) break;
                    }
                    if (stop) break;
                }
            }
        }
    }
}
