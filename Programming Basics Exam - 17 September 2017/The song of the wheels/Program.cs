using System;

namespace The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 1;
            int passA = 0;
            int passB = 0;
            int passC = 0;
            int passD = 0;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        { 
                            if (a < b && c > d && (a * b + c * d) == n)
                            {
                                Console.Write($"{a}{b}{c}{d} "); 
                                if (count == 4)
                                {
                                    passA = a;
                                    passB = b;
                                    passC = c;
                                    passD = d;
                                }
                                count++;
                            }
                        }
                    }
                }
            }

            if (count >= 4)
            {
                Console.WriteLine("");
                Console.WriteLine($"Password: {passA}{passB}{passC}{passD} ");
            }

            if (count < 4)
            {
                Console.WriteLine("");
                Console.WriteLine("No!");
            }


        }
    }
}
