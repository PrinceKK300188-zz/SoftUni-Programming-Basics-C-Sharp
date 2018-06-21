using System;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());


            Console.WriteLine(Math.Abs(x1-x2) * Math.Abs(y1 - y2));
            Console.WriteLine(Math.Abs(x1 - x2) * 2 + Math.Abs(y1 - y2) * 2);
        }
    }
}
