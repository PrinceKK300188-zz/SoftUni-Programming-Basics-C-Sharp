using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0.0;
            double diff = 0.0;

            for (int i = 0; i < n; i++)
            {
                double number1 = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());

                double newSum = number1 + number2;
                if (i > 0)
                {
                    if (sum != newSum)
                    {
                        double newDiff = Math.Abs(sum - newSum);
                        if (newDiff > diff)
                        {
                            diff = newDiff;
                        }
                        sum = newSum;
                    }
                }
                else
                {
                    sum = newSum;
                }
            }

            if (diff == 0.0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", diff);
                
            }
            
        }
    }
}
