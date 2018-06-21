using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondsOne = int.Parse(Console.ReadLine());
            int secondsTwo = int.Parse(Console.ReadLine());
            int secondsThree = int.Parse(Console.ReadLine());

            int sum = secondsOne + secondsTwo + secondsThree;
            int minutes = sum / 60;
            int secondsLeft = sum - minutes * 60;

            
            if (secondsLeft < 10)
            {
                Console.WriteLine(minutes + ":0" + secondsLeft);
            }
            else
            {
                Console.WriteLine(minutes + ":" + secondsLeft);
            }
                
        }
    }
}
