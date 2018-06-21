using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine("Triangle area = " + side*height/2);
        }
    }
}
