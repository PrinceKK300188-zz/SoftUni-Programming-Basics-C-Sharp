using System;

namespace Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double sum = 0;
            double de = 0;
            for (int i = 1; i <= days; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                double degree = double.Parse(Console.ReadLine());

                sum += quantity;
                de += quantity * degree;
            }

            de = de / sum;
            Console.WriteLine($"Liter: {sum:F2}");
            Console.WriteLine($"Degrees: {de:F2}");
            if (de < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (de >= 38 && de <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (de > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
