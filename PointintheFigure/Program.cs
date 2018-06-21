using System;

namespace PointintheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int pointX = int.Parse(Console.ReadLine());
            int pointY = int.Parse(Console.ReadLine());

            int x0 = 0;
            int y0 = 0;
            int x1 = 3 * h;
            int y1 = 0;
            int x2 = 3 * h;
            int y2 = h;
            int x3 = 2 * h;
            int y3 = h;
            int x4 = 2 * h;
            int y4 = 4 * h;
            int x5 = h;
            int y5 = 4 * h;
            int x6 = h;
            int y6 = h;
            int x7 = 0;
            int y7 = h;

            var output = "";
            //Проверка дали точката е вътре в хоризонталният правоъгълник
            if (pointX > x0 && pointX < x1 && pointY > y0 && pointY < y7)
            {
                output = "inside";
            }

            //Проверка дали точката е вътре във вертикалният правоъгълник
            if (pointX > x6 && pointX < x3 && pointY > y6 && pointY < y5)
            {
                output = "inside";
            }

            //проверка дали точката е в рамката застъпена от двата правоъгълника
            if (pointX > x6 && pointX < x3 && pointY == y3)
            {
                output = "inside";
            }

            //Проверки дали не попада в рамките
            if (pointX >= x0 && pointX <= x1 && pointY == y0)
            {
                output = "border";
            }

            if (pointX == x1 && pointY >= y1 && pointY <= y2 )
            {
                output = "border";
            }

            if (pointX >= x3 && pointX <= x2 && pointY == y2)
            {
                output = "border";
            }

            if (pointX == x3 && pointY >= y3 && pointY <= y4)
            {
                output = "border";
            }

            if (pointX >= x5 && pointX <= x4 && pointY == y4)
            {
                output = "border";
            }

            if (pointX == x6 && pointY >= y6 && pointY <= y5)
            {
                output = "border";
            }

            if (pointX >= x7 && pointX <= x6 && pointY == y6)
            {
                output = "border";
            }

            if (pointX == x0 && pointY >= y0 && pointY <= y7)
            {
                output = "border"; ;
            }

            if (output == "")
            {
                output = "outside";
            }
            Console.WriteLine(output);
        }
    }
}
