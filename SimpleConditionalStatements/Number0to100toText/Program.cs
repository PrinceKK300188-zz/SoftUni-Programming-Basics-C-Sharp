using System;
using System.Collections.Generic;

namespace Number0to100toText
{
    class Program
    {
        static void Main(string[] args)
        {
            int imput = int.Parse(Console.ReadLine());
            //var digits = new Dictionary<int, string>();
            //var numbers = new Dictionary<int, string>();

            string[] kdigits = new string[20] 
            { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            string[] knumbers = new string[9]
                { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "one hundred"};

            
            if (imput >= 0 && imput < 20)
            {
                imput = Math.Abs(imput);
                Console.WriteLine(kdigits[imput]);
            }
            else if (imput >= 20 && imput <= 100)
            {
                imput = Math.Abs(imput);
                int firstdigit = imput / 10;
                int seconddigit = imput % 10;
                if (seconddigit == 0)
                {
                    Console.WriteLine(knumbers[firstdigit - 2]);
                }
                else
                {
                    Console.WriteLine(knumbers[firstdigit - 2] + " " + kdigits[seconddigit]);
                }
            }
            else
            {
                Console.WriteLine("invalid number"); 
            }
            
        }
    }
}
