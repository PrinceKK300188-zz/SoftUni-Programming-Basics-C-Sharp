using System;

namespace ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            var fname = Console.ReadLine();
            var lname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var city = Console.ReadLine();

            Console.WriteLine($"You are {fname} {lname}, a {age}-years old person from {city}.");
        }
    }
}
