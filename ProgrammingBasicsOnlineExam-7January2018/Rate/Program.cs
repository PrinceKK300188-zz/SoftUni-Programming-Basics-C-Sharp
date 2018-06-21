using System;

namespace Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            double simpleSum = sum;
            //Изчисляване на простата лихва
            for (int i = 0; i < month; i++)
            {
                simpleSum = simpleSum + sum * (3 / 100.0);
            }

            double complexSum = sum;
            //Изчисляване на сложната лихва
            for (int i = 0; i < month; i++)
            {
                complexSum = complexSum + complexSum * (2.7 / 100.0);
            }

            Console.WriteLine($"Simple interest rate: {simpleSum:F2} lv.");
            Console.WriteLine($"Complex interest rate: {complexSum:F2} lv.");

            string type = "complex";
            if (simpleSum > complexSum)
            {
                type = "simple";
            }
            Console.WriteLine("Choose a {0} interest rate. You will win {1:F2} lv.", type, Math.Abs(simpleSum - complexSum));
        }
    }
}
