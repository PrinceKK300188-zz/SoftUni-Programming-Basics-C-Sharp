using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            if ((minutes + 15) >= 60)
            {
                if (hour == 23)
                {
                    hour = 0;
                }
                else
                {
                    hour += 1;
                }
                    
                minutes = minutes - 45;
            }
            else
            {
                minutes += 15;
            }

            if (minutes < 10)
            {
                Console.WriteLine(hour + ":0"+ minutes);
            }
            else
            {
                Console.WriteLine(hour + ":"+ minutes);
            }
           
        }
    }
}
