using System;

namespace CelsiustoFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var cel = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(cel*9/5.00+32.00, 2));
        }
    }
}
