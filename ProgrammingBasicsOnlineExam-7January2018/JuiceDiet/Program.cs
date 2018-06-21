using System;

namespace JuiceDiet
{
    class Program
    {
        static void Main(string[] args)
        {
            int Raspberries = int.Parse(Console.ReadLine());
            int Strawberries = int.Parse(Console.ReadLine());
            int Cherries = int.Parse(Console.ReadLine());
            int quantity = int.Parse(Console.ReadLine());

            double totalJuice = 0;
            double maxJuice = 0;
            int countRaspberries = 0;
            int countStrawberries = 0;
            int countCherries = 0;

            for (int a = 0; a <= Raspberries; a++)
            {
                for (int b = 0; b <= Strawberries; b++)
                {
                    for (int c = 0; c <= Cherries; c++)
                    {
                        totalJuice = (a * 4.5) + (b * 7.5) + (c * 15);
                        if (totalJuice <= quantity)
                        {
                            if (totalJuice > maxJuice)
                            {
                                maxJuice = totalJuice;
                                countRaspberries = a;
                                countStrawberries = b;
                                countCherries = c;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"{countRaspberries} Raspberries, {countStrawberries} Strawberries, {countCherries} Cherries. Juice: {maxJuice} ml.");
            
        }
    }
}
