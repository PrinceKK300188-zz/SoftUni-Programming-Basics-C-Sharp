using System;

namespace _3EqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double one = double.Parse(Console.ReadLine());
            double two = double.Parse(Console.ReadLine());
            double three = double.Parse(Console.ReadLine());

            if (one != two)
            {
                Console.WriteLine("no");
            }
            else
            {
                if (two != three)
                {
                    Console.WriteLine("no");
                }
                else
                {
                    Console.WriteLine("yes");
                }
            }
        }
    }
}
