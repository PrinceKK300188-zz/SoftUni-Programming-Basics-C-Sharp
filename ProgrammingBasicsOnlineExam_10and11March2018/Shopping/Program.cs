using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            double milk = double.Parse(Console.ReadLine());

            double sum = (double)number * 0.65 + milk * 2.70 + Math.Truncate(number - number * 0.35) * 0.20;

            if (sum > budjet)
            {
                Console.WriteLine($"Not enough money, you need {(sum - budjet):F2} more!");

            }
            else
            {
                Console.WriteLine($"You got this, {(budjet - sum):F2} money left!");
            }
            
        }
    }
}
