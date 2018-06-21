using System;

namespace InchestoCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var i = double.Parse(Console.ReadLine());
            Console.WriteLine("Centimeters = " + i*2.54);
        }
    }
}
