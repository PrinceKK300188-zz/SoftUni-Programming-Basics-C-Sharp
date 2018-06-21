using System;

namespace Dwarf_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            int dorfNumber = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            

            double finalSum = 0.0;
            for (int i = 1; i <= dorfNumber; i++)
            {
                string type = Console.ReadLine();
                switch (type)
                {
                    case "sand clock":
                        finalSum = finalSum + 2.20;
                        break;
                    case "magnet":
                        finalSum = finalSum + 1.50;
                        break;
                    case "cup":
                        finalSum = finalSum + 5.0;
                        break;
                    case "t-shirt":
                        finalSum = finalSum + 10.0;
                        break;
                }
            }

            if (sum >= finalSum)
            {
                double diff = sum - finalSum;
                Console.WriteLine($"Santa Claus has {diff:F2} more leva left!");
            }
            else
            {
                double diff = finalSum - sum;
                Console.WriteLine($"Santa Claus will need {diff:F2} more leva.");
            }
        }
    }
}
