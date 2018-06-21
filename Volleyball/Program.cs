using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfYear = Console.ReadLine();
            int dayoff = int.Parse(Console.ReadLine());
            int travel = int.Parse(Console.ReadLine());

            double SofiaWeekend = 48 - travel;
            double PlayInSofia = SofiaWeekend * 3.0 / 4.0;
            double DayOffPlay = dayoff * 2.0 / 3.0;
            double play = PlayInSofia + DayOffPlay + travel;
            

            if (typeOfYear == "leap")
            {
                double LeapPlay = play + play * 15 / 100;
                Console.WriteLine((int)LeapPlay);
            }
            else if (typeOfYear == "normal")
            {
                Console.WriteLine((int)play);
            }
        }
    }
}
