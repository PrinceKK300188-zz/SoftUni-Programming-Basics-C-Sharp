using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            double output = 0.000;

            if (figure == "square")
            {
                var sSide = double.Parse(Console.ReadLine());
                output = sSide * sSide;
                
            } 
            else if (figure == "rectangle")
            {
                var sideOne = double.Parse(Console.ReadLine());
                var sideTwo = double.Parse(Console.ReadLine());
                output = sideOne * sideTwo;
            }
            else if (figure == "circle")
            {
                var perimeter = double.Parse(Console.ReadLine());
                output = perimeter * perimeter * Math.PI;
            }
            else if (figure == "triangle")
            {
                var sideOne = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());

                output = sideOne * height / 2;
            }
            output = Math.Round(output, 3);

            Console.WriteLine(output);


        }
    }
}
