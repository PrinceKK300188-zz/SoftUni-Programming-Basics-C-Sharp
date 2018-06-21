using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            double bonusPoints;
            if (points <= 100 )
            {
                bonusPoints = 5;
            }
            else if (points > 100 && points <= 1000)
            {
                bonusPoints = points * 20.0 / 100;
            }
            else {
                bonusPoints = points * 10.0 / 100;
            }

            if (points % 2 == 0)
            {
                bonusPoints += 1;
            }

            if (points % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(points+bonusPoints);
        }
    }
}
