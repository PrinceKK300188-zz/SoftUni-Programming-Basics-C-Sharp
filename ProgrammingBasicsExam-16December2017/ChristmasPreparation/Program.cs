using System;

namespace ChristmasPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int paperNumber = int.Parse(Console.ReadLine());
            int textilNumber = int.Parse(Console.ReadLine());
            double clueNumber = double.Parse(Console.ReadLine());
            int reduction = int.Parse(Console.ReadLine());


            double sum = (paperNumber * 5.8) + (textilNumber * 7.2) + (clueNumber * 1.2);
            double sumAfterReduction = sum - sum * reduction / 100.0;

            Console.WriteLine($"{sumAfterReduction:F3}");
        }
    }
}
