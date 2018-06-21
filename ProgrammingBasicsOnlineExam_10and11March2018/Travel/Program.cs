using System;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double truckSpeed = double.Parse(Console.ReadLine());
            double speedDifference = double.Parse(Console.ReadLine());

            speedDifference = speedDifference * 3.6;

            double autoSpeed = truckSpeed + speedDifference;

            double truckTime = distance / truckSpeed;
            double autoTime = distance / autoSpeed;

            Console.WriteLine($"The truck arrived after {Math.Ceiling(truckTime)} hours");
            Console.WriteLine($"The car arrived after {Math.Ceiling(autoTime)} hours");
        }
    }
}
