using System;

namespace RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(rad * 180 / Math.PI, 0));
        }
    }
}
