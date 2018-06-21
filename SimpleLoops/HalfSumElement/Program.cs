using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int largestNumber = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (largestNumber <= input)
                {
                    largestNumber = input;
                }
                sum += input;
            }

            if (largestNumber == (sum - largestNumber))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", largestNumber);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(largestNumber - (sum - largestNumber)));
            }
            
        }
    }
}
