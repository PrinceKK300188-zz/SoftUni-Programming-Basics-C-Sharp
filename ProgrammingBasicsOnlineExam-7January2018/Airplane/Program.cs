using System;

namespace Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());


            int startMinutes = int.Parse(Console.ReadLine());


            int flyMinutes = int.Parse(Console.ReadLine());


            int count = startMinutes + flyMinutes;
            int countHour = 0;
            int minutesLeft = 0;
            int hours = 0;
            if (count >= 60)
            {
                countHour = count / 60;
                minutesLeft = count % 60;
                hours = startHour + countHour;
                
            }
            else
            {
                hours = startHour;
                minutesLeft = count;
            }
            if (hours >= 24)
            {
                hours = hours - 24;
            }
            Console.WriteLine($"{hours}h {minutesLeft}m");
        }
    }
}
