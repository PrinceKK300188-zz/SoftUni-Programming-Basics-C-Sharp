using System;

namespace testRound
{
    class Program
    {
        static void Main(string[] args)
        {
            double overKm = 234.0;
            double c = overKm - Math.Truncate(overKm); 
            if (c > 0)
            {
                overKm = Math.Truncate(overKm) + 1;
            }

            //overKm = Math.Round(overKm, 0, MidpointRounding.AwayFromZero);
            Console.WriteLine(c);
            Console.WriteLine(overKm);
        }
    }
}
