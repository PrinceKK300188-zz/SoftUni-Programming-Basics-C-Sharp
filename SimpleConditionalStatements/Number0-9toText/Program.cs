using System;

namespace Number0_9toText
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] Number = new string[10] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            
        
            if (n >= 10)
            {
                Console.WriteLine("number too big");
            }
            else
            {
                Console.WriteLine(Number[n]);
            }
            
        }
    }
}
