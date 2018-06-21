using System;
using System.Collections.Generic;

namespace DayofWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number > 0 && number < 8)
            {
                var day = new Dictionary<int, string>();

                day[0] = "Monday";
                day[1] = "Tuesday";
                day[2] = "Wednesday";
                day[3] = "Thursday";
                day[4] = "Friday";
                day[5] = "Saturday";
                day[6] = "Sunday";
                Console.WriteLine(day[number-1]);
            }
            else
            {
                Console.WriteLine("Error");
            }

            
        }
    }
}
