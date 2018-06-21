using System;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int points = 0;
            int redPoints = 0;
            int orangePoints = 0;
            int yellowPoints = 0;
            int whitePoints = 0;
            int blackPoints = 0;
            int otherPoints = 0;

            for (int i = 1; i <= n; i++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    points += 5;
                    redPoints++;
                }
                else if (color == "orange")
                {
                    points += 10;
                    orangePoints++;
                }
                else if (color == "yellow")
                {
                    points += 15;
                    yellowPoints++;
                }
                else if (color == "white")
                {
                    points += 20;
                    whitePoints++;
                }
                else if (color == "black")
                {
                    points = points / 2;
                    blackPoints++;
                }
                else
                {
                    otherPoints++;
                }


            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {redPoints}");
            Console.WriteLine($"Points from orange balls: {orangePoints}");
            Console.WriteLine($"Points from yellow balls: {yellowPoints}");
            Console.WriteLine($"Points from white balls: {whitePoints}");
            Console.WriteLine($"Other colors picked: {otherPoints}");
            Console.WriteLine($"Divides from black balls: {blackPoints}");

        }
    }
}
