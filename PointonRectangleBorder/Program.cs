using System;

namespace PointonRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double point1 = double.Parse(Console.ReadLine());
            double point2 = double.Parse(Console.ReadLine());

            if (x1 > x2)
            {
                double newx = x2;
                x2 = x1; x1 = newx;
            }


            if (y1 > y2)
            {
                double newy = y2;
                y2 = y1; y1 = newy;
            }

            if ((x1 == point1 && point2 >= y1 && point2 <= y2)
                || (x2 == point1 && point2 >= y1 && point2 <= y2)
                || (y1 == point2 && point1 >= x1 && point1 <= x2)
                || (y2 == point2 && point1 >= x1 && point1 <= x2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }

            //var result = 23.345656767;
            //Console.WriteLine("{0:f3}", result);

            //Console.WriteLine(Math.Round(result, 3));
        }
    }
}
