using System;
using System.Collections.Generic;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double longs = double.Parse(Console.ReadLine());
            var first = Console.ReadLine();
            var second = Console.ReadLine();

            var metrics = new Dictionary<string, double>();


            metrics["mm"] = 1 / 1000.0;
            metrics["cm"] = 1 / 100.0;
            metrics["mi"] = 1 / 0.000621371192;
            metrics["in"] = 1 / 39.3700787;
            metrics["km"] = 1 / 0.001;
            metrics["ft"] = 1 / 3.2808399;
            metrics["yd"] = 1 / 1.0936133;
            metrics["m"] = 1 / 1.0;

            var dimensions = new Dictionary<string, double>();
            dimensions["mm"] = 1000.0;
            dimensions["cm"] = 100.0;
            dimensions["mi"] = 0.000621371192;
            dimensions["in"] = 39.3700787;
            dimensions["km"] = 0.001;
            dimensions["ft"] = 3.2808399;
            dimensions["yd"] = 1.0936133;
            dimensions["m"] = 1.0;

            Console.WriteLine(longs * metrics[first] * dimensions[second] + " " + second);


        }
    }
}
