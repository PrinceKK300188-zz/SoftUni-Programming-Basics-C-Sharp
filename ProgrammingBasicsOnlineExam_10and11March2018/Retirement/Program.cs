using System;

namespace Retirement
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            if (gender == "female" && age > 1 && age < 10000 && years > 1 && years < 10000)
            {
                if (age >= 61 && years >= 35)
                {
                    Console.WriteLine($"Ready to retire at {age} and {years} years of experience!");
                }
                else if (age >= 61 && years < 35)
                {
                    Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {35 - years}.");
                }
                else if (age < 61 && years >= 35)
                {
                    int vv = 61 - age;
                    Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {vv}.");
                }
                else if (age < 61 && years < 35)
                {
                    Console.WriteLine($"Too early. Years left to retirement: {61 - age}. Work experience left to retirement: {35 - years}.");
                }
            }
            else if ( gender == "male" && age > 1 && age < 10000 && years > 1 && years < 10000)
            {
                if (age >= 64 && years >= 38)
                {
                    Console.WriteLine($"Ready to retire at {age} and {years} years of experience!");
                }
                else if (age >= 64 && years < 38)
                {
                    Console.WriteLine($"Old enough, but haven't worked enough. Work experience left to retirement: {38 - years}.");
                }
                else if (age < 64 && years >= 38)
                {
                    int vv = 64 - age;
                    Console.WriteLine($"Worked enough, but not old enough. Years left to retirement: {vv}.");
                }
                else if (age < 64 && years < 38)
                {
                    Console.WriteLine($"Too early. Years left to retirement: {64 - age}. Work experience left to retirement: {38 - years}.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            
        }
    }
}
