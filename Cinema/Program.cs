using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var income = 0.00;
            if (type == "Premiere")
            {
                income = a * b * 12.00;
            }
            else if (type == "Normal")
            {
                income = a * b * 7.50;
            }
            else if (type == "Discount")
            {
                income = a * b * 5.00;
            }
            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
