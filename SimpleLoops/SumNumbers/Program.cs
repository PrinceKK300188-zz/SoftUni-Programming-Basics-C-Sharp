using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int input = 0;
            for (int i = 0; i < n; i++)
            {
                int userinput = int.Parse(Console.ReadLine());
                input += userinput;
                
            }
            Console.WriteLine(input);
        }
    }
}
